using System;

using R5T.Norsica;
using R5T.Pompeii;


namespace R5T.Antium.Default
{
    public class DotnetPublishOperation : IPublishOperation
    {
        private IEntryPointProjectFilePathProvider EntryPointProjectFilePathProvider { get; }
        private IEntryPointProjectBuildOutputPublishDirectoryPathProvider EntryPointProjectBuildOutputPublishDirectoryPathProvider { get; }
        private IDotnetCommandLineOperator DotnetCommandLineOperator { get; }


        public DotnetPublishOperation(
            IEntryPointProjectFilePathProvider entryPointProjectFilePathProvider,
            IDotnetCommandLineOperator dotnetCommandLineOperator,
            IEntryPointProjectBuildOutputPublishDirectoryPathProvider entryPointProjectBuildOutputPublishDirectoryPathProvider)
        {
            this.EntryPointProjectFilePathProvider = entryPointProjectFilePathProvider;
            this.DotnetCommandLineOperator = dotnetCommandLineOperator;
            this.EntryPointProjectBuildOutputPublishDirectoryPathProvider = entryPointProjectBuildOutputPublishDirectoryPathProvider;
        }

        public void Execute()
        {
            var projectFilePath = this.EntryPointProjectFilePathProvider.GetEntryPointProjectFilePath();

            var publishDirectoryPath = this.EntryPointProjectBuildOutputPublishDirectoryPathProvider.GetEntryPointProjectBuildOutputPublishDirectoryPath();

            this.DotnetCommandLineOperator.PublishApp(projectFilePath, publishDirectoryPath);
        }
    }
}
