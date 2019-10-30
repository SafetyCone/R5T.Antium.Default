using System;

using R5T.Gepidia;
using R5T.Gepidia.Local;
using R5T.Lombardy;
using R5T.Pompeii;


namespace R5T.Antium.Default
{
    public class DefaultDeploymentSourceFileSystemSiteProvider : IDeploymentSourceFileSystemSiteProvider
    {
        private IProjectBuildOutputBinariesDirectoryPathProvider ProjectOutputBinariesDirectoryPathProvider { get; }
        private LocalFileSystemOperator LocalFileSystemOperator { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public DefaultDeploymentSourceFileSystemSiteProvider(IProjectBuildOutputBinariesDirectoryPathProvider projectOutputBinariesDirectoryPathProvider,
            LocalFileSystemOperator localFileSystemOperator,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.ProjectOutputBinariesDirectoryPathProvider = projectOutputBinariesDirectoryPathProvider;
            this.LocalFileSystemOperator = localFileSystemOperator;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public FileSystemSite GetDeploymentSourceFileSystemSite()
        {
            var projectOutputBinariesDirectoryPath = this.ProjectOutputBinariesDirectoryPathProvider.GetProjectBuildOutputBinariesDirectoryPath();
            var ensuredProjectOutputBinariesDirectoryPath = this.StringlyTypedPathOperator.EnsureDirectoryPathIsDirectoryIndicated(projectOutputBinariesDirectoryPath);

            var projectOutputBinariesLocalFileSystemSite = new FileSystemSite(ensuredProjectOutputBinariesDirectoryPath, this.LocalFileSystemOperator);
            return projectOutputBinariesLocalFileSystemSite;
        }
    }
}
