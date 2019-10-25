using System;

using R5T.Gepidia;
using R5T.Gepidia.Local;
using R5T.Jutland;
using R5T.Lombardy;
using R5T.Suebia;


namespace R5T.Antium.Default
{
    /// <summary>
    /// Gets local deployment destination file-system site details from a secrets file.
    /// </summary>
    public class SecretsFileLocalDeploymentDestinationFileSystemSiteProvider : IDeploymentDestinationFileSystemSiteProvider
    {
        private IDeploymentDestinationSecretsFileNameProvider DeploymentDestinationSecretsFileNameProvider { get; }
        private ISecretsFilePathProvider SecretsFilePathProvider { get; }
        private IJsonFileSerializationOperator JsonFileSerializationOperator { get; }
        private LocalFileSystemOperator LocalFileSystemOperator { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public SecretsFileLocalDeploymentDestinationFileSystemSiteProvider(IDeploymentDestinationSecretsFileNameProvider deploymentDestinationSecretsFileNameProvider, ISecretsFilePathProvider secretsFilePathProvider,
            IJsonFileSerializationOperator jsonFileSerializationOperator,
            LocalFileSystemOperator localFileSystemOperator, IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.DeploymentDestinationSecretsFileNameProvider = deploymentDestinationSecretsFileNameProvider;
            this.SecretsFilePathProvider = secretsFilePathProvider;
            this.JsonFileSerializationOperator = jsonFileSerializationOperator;
            this.LocalFileSystemOperator = localFileSystemOperator;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public FileSystemSite GetDeploymentDestinationFileSystemSite()
        {
            var deploymentDestinationSecretsFileName = this.DeploymentDestinationSecretsFileNameProvider.GetDeploymentDestinationSecretsFileName();

            var deploymentDestinationSecretsFilePath = this.SecretsFilePathProvider.GetSecretsFilePath(deploymentDestinationSecretsFileName);

            // Load the type from JSON and get the local directory path.
            var localDeploymentSecretsSerialization = this.JsonFileSerializationOperator.Deserialize<LocalDeploymentSecretsSerialization>(deploymentDestinationSecretsFilePath);

            var ensuredDeploymentDirectoryPath = this.StringlyTypedPathOperator.EnsureDirectoryPathIsDirectoryIndicated(localDeploymentSecretsSerialization.DirectoryPath);

            var deploymentDestinationSite = new FileSystemSite(ensuredDeploymentDirectoryPath, this.LocalFileSystemOperator);
            return deploymentDestinationSite;
        }
    }
}
