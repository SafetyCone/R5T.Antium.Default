using System;

using R5T.Norsica;
using R5T.Pompeii;


namespace R5T.Antium.Default
{
    public class DotnetPublicationOperator : IPublicationOperator
    {
        private IEntryPointProjectFilePathProvider EntryPointProjectFilePathProvider { get; }
        private IEntryPointProjectBuildOutputPublishDirectoryPathProvider EntryPointProjectBuildOutputPublishDirectoryPathProvider { get; }
        private IDotnetOperator DotnetOperator { get; }


        public DotnetPublicationOperator(
            IEntryPointProjectFilePathProvider entryPointProjectFilePathProvider,
            IDotnetOperator dotnetCommandLineOperator,
            IEntryPointProjectBuildOutputPublishDirectoryPathProvider entryPointProjectBuildOutputPublishDirectoryPathProvider)
        {
            this.EntryPointProjectFilePathProvider = entryPointProjectFilePathProvider;
            this.DotnetOperator = dotnetCommandLineOperator;
            this.EntryPointProjectBuildOutputPublishDirectoryPathProvider = entryPointProjectBuildOutputPublishDirectoryPathProvider;
        }

        public void Publish()
        {
            var projectFilePath = this.EntryPointProjectFilePathProvider.GetEntryPointProjectFilePath();

            var publishDirectoryPath = this.EntryPointProjectBuildOutputPublishDirectoryPathProvider.GetEntryPointProjectBuildOutputPublishDirectoryPath();

            //this.DotnetOperator.Publish(projectFilePath, publishDirectoryPath);
            this.DotnetOperator.Publish(projectFilePath, publishDirectoryPath, "Debug");
        }
    }
}
