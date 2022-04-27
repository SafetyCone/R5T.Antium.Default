using System;

using R5T.Gepidia;
using R5T.Gepidia.Local;
using R5T.Lombardy;

using R5T.T0064;


namespace R5T.Antium.Default
{
    /// <summary>
    /// Provides a local deployment destination file system site using the <see cref="LocalDeploymentSecretsSerialization.DirectoryPath"/> value.
    /// </summary>
    [ServiceImplementationMarker]
    public class SecretsFileLocalDeploymentDestinationFileSystemSiteProvider : IDeploymentDestination_FileSystemSiteProvider, IServiceImplementation
    {
        private ILocalDeploymentSecretsSerializationProvider LocalDeploymentSecretsSerializationProvider { get; }
        private ILocalFileSystemOperator LocalFileSystemOperator { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public SecretsFileLocalDeploymentDestinationFileSystemSiteProvider(
            ILocalDeploymentSecretsSerializationProvider localDeploymentSecretsSerializationProvider,
            ILocalFileSystemOperator localFileSystemOperator,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.LocalDeploymentSecretsSerializationProvider = localDeploymentSecretsSerializationProvider;
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
