using System;

using R5T.Gepidia;
using R5T.Gepidia.Local;
using R5T.Suebia;


namespace R5T.Antium.Default
{
    public class DefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider : IDeploymentSource_SecretsDirectory_FileSystemSiteProvider
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
