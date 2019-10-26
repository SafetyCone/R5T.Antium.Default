using System;

using R5T.Gepidia;
using R5T.Gepidia.Remote;
using R5T.Lombardy;


namespace R5T.Antium.Default
{
    public class SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider : IDeploymentDestinationFileSystemSiteProvider
    {
        private RemoteDeploymentSecretsSerialization RemoteDeploymentSecretsSerialization { get; }
        private RemoteFileSystemOperator RemoteFileSystemOperator { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider(RemoteDeploymentSecretsSerialization remoteDeploymentSecretsSerialization,
            RemoteFileSystemOperator remoteFileSystemOperator,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.RemoteDeploymentSecretsSerialization = remoteDeploymentSecretsSerialization;
            this.RemoteFileSystemOperator = remoteFileSystemOperator;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public FileSystemSite GetDeploymentDestinationFileSystemSite()
        {
            var ensuredDirectoryPath = this.StringlyTypedPathOperator.EnsureDirectoryPathIsDirectoryIndicated(this.RemoteDeploymentSecretsSerialization.DirectoryPath);

            var remoteFileSystemSite = new FileSystemSite(ensuredDirectoryPath, this.RemoteFileSystemOperator);
            return remoteFileSystemSite;
        }
    }
}
