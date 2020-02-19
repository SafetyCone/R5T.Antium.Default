using System;

using R5T.Gepidia;
using R5T.Gepidia.Remote;
using R5T.Lombardy;


namespace R5T.Antium.Default
{
    public class SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider : IDeploymentDestinationFileSystemSiteProvider
    {
        private IRemoteDeploymentSecretsSerializationProvider RemoteDeploymentSecretsSerializationProvider { get; }
        private IRemoteFileSystemOperator RemoteFileSystemOperator { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider(
            IRemoteDeploymentSecretsSerializationProvider remoteDeploymentSecretsSerializationProvider,
            IRemoteFileSystemOperator remoteFileSystemOperator,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.RemoteDeploymentSecretsSerializationProvider = remoteDeploymentSecretsSerializationProvider;
            this.RemoteFileSystemOperator = remoteFileSystemOperator;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public FileSystemSite GetDeploymentDestinationFileSystemSite()
        {
            var remoteDeploymentSecretsSerialization = this.RemoteDeploymentSecretsSerializationProvider.GetRemoteDeploymentSecretsSerialization();

            var ensuredDirectoryPath = this.StringlyTypedPathOperator.EnsureDirectoryPathIsDirectoryIndicated(remoteDeploymentSecretsSerialization.DirectoryPath);

            var remoteFileSystemSite = new FileSystemSite(ensuredDirectoryPath, this.RemoteFileSystemOperator);
            return remoteFileSystemSite;
        }
    }
}
