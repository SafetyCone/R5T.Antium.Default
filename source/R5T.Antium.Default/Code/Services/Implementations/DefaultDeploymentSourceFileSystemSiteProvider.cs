using System;

using R5T.Gepidia;
using R5T.Gepidia.Local;
using R5T.Lombardy;
using R5T.Pompeii;

using R5T.T0064;


namespace R5T.Antium.Default
{
    [ServiceImplementationMarker]
    public class DefaultDeploymentSourceFileSystemSiteProvider : IDeploymentSource_FileSystemSiteProvider, IServiceImplementation
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
