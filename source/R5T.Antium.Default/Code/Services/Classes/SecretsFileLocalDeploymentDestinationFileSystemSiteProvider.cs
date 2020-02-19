using System;

using R5T.Gepidia;
using R5T.Gepidia.Local;
using R5T.Lombardy;


namespace R5T.Antium.Default
{
    /// <summary>
    /// Gets local deployment destination file-system site details from a secrets file.
    /// </summary>
    public class SecretsFileLocalDeploymentDestinationFileSystemSiteProvider : IDeploymentDestinationFileSystemSiteProvider
    {
        private ILocalDeploymentSecretsSerializationProvider LocalDeploymentSecretsSerializationProvider { get; }
        private ILocalFileSystemOperator LocalFileSystemOperator { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public SecretsFileLocalDeploymentDestinationFileSystemSiteProvider(
            ILocalDeploymentSecretsSerializationProvider localDeploymentSecretsSerializationProvider,
            ILocalFileSystemOperator localFileSystemOperator,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.LocalFileSystemOperator = localFileSystemOperator;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public FileSystemSite GetDeploymentDestinationFileSystemSite()
        {
            var localDeploymentSecretsSerialization = this.LocalDeploymentSecretsSerializationProvider.GetLocalDeploymentSecretsSerialization();

            var ensuredDeploymentDirectoryPath = this.StringlyTypedPathOperator.EnsureDirectoryPathIsDirectoryIndicated(localDeploymentSecretsSerialization.DirectoryPath);

            var deploymentDestinationSite = new FileSystemSite(ensuredDeploymentDirectoryPath, this.LocalFileSystemOperator);
            return deploymentDestinationSite;
        }
    }
}
