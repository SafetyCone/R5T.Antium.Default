using System;

using R5T.Gepidia;
using R5T.Gepidia.Remote;
using R5T.Lombardy;


namespace R5T.Antium.Default
{
    public class DefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProvider : IDeploymentDestination_SecretsDirectory_FileSystemSiteProvider
    {
        private IRemoteFileSystemOperator RemoteFileSystemOperator { get; }
        private IRemoteDeploymentSecretsSerializationProvider RemoteDeploymentSecretsSerializationProvider { get; }


        public DefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProvider(
            IRemoteFileSystemOperator remoteFileSystemOperator,
            IRemoteDeploymentSecretsSerializationProvider remoteDeploymentSecretsSerializationProvider)
        {
            this.RemoteFileSystemOperator = remoteFileSystemOperator;
            this.RemoteDeploymentSecretsSerializationProvider = remoteDeploymentSecretsSerializationProvider;
        }

        public FileSystemSite GetDeploymentDestinationSecretsDirectoryFileSystemSite()
        {
            var remoteDeploymentSecretsSerialization = this.RemoteDeploymentSecretsSerializationProvider.GetRemoteDeploymentSecretsSerialization();

            var remoteSecretsDirectoryPath = remoteDeploymentSecretsSerialization.DirectoryPath; // Put secrets files into the same directory as all the code.

            var remoteSecretsDirectoryFileSystemSite = new FileSystemSite(remoteSecretsDirectoryPath, this.RemoteFileSystemOperator);
            return remoteSecretsDirectoryFileSystemSite;
        }
    }
}
