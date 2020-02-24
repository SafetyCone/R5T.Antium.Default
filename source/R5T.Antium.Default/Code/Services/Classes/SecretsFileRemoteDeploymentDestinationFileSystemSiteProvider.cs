using System;

using R5T.Gepidia;
using R5T.Gepidia.Remote;
using R5T.Lombardy;


namespace R5T.Antium.Default
{
    /// <summary>
    /// Provides a remote deployment destination file system site using the <see cref="RemoteDeploymentSecretsSerialization.DirectoryPath"/> value.
    /// </summary>
    public class SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider : IDeploymentDestination_FileSystemSiteProvider
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
