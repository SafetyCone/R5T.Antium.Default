using System;

using R5T.Gepidia;
using R5T.Gepidia.Local;
using R5T.Suebia;

using R5T.T0064;


namespace R5T.Antium.Default
{
    [ServiceImplementationMarker]
    public class DefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider : IDeploymentSource_SecretsDirectory_FileSystemSiteProvider, IServiceImplementation
    {
        private ILocalFileSystemOperator LocalFileSystemOperator { get; }
        private ISecretsDirectoryPathProvider SecretsDirectoryPathProvider { get; }

        
        public DefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider(
            ILocalFileSystemOperator localFileSystemOperator,
            ISecretsDirectoryPathProvider secretsDirectoryPathProvider)
        {
            this.LocalFileSystemOperator = localFileSystemOperator;
            this.SecretsDirectoryPathProvider = secretsDirectoryPathProvider;
        }

        public FileSystemSite GetDeploymentSourceSecretsDirectoryFileSystemSite()
        {
            var secretsDirectoryPath = this.SecretsDirectoryPathProvider.GetSecretsDirectoryPath();

            var secretsDirectoryFileSystemSite = new FileSystemSite(secretsDirectoryPath, this.LocalFileSystemOperator);
            return secretsDirectoryFileSystemSite;
        }
    }
}
