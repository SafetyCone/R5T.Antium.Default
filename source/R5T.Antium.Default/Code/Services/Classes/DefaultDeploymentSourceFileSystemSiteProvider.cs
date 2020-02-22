using System;

using R5T.Gepidia;
using R5T.Gepidia.Local;
using R5T.Lombardy;
using R5T.Pompeii;


namespace R5T.Antium.Default
{
    public class DefaultDeploymentSourceFileSystemSiteProvider : IDeploymentSourceFileSystemSiteProvider
    {
        private IProjectBuildOutputBinariesDirectoryPathProvider ProjectBuildOutputBinariesDirectoryPathProvider { get; }
        private ILocalFileSystemOperator LocalFileSystemOperator { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public DefaultDeploymentSourceFileSystemSiteProvider(
            IProjectBuildOutputBinariesDirectoryPathProvider projectOutputBinariesDirectoryPathProvider,
            ILocalFileSystemOperator localFileSystemOperator,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.ProjectBuildOutputBinariesDirectoryPathProvider = projectOutputBinariesDirectoryPathProvider;
            this.LocalFileSystemOperator = localFileSystemOperator;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public FileSystemSite GetDeploymentSourceFileSystemSite()
        {
            var projectOutputBinariesDirectoryPath = this.ProjectBuildOutputBinariesDirectoryPathProvider.GetProjectBuildOutputBinariesDirectoryPath();
            var ensuredProjectOutputBinariesDirectoryPath = this.StringlyTypedPathOperator.EnsureDirectoryPathIsDirectoryIndicated(projectOutputBinariesDirectoryPath);

            var projectOutputBinariesLocalFileSystemSite = new FileSystemSite(ensuredProjectOutputBinariesDirectoryPath, this.LocalFileSystemOperator);
            return projectOutputBinariesLocalFileSystemSite;
        }
    }
}
