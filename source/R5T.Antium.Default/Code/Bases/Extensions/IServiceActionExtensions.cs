using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Frisia.Suebia;
using R5T.Gepidia.Local;
using R5T.Gepidia.Remote;
using R5T.Jutland;
using R5T.Lombardy;
using R5T.Norsica;
using R5T.Pompeii;
using R5T.Suebia;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Antium.Default
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DefaultDeploymentSourceFileSystemSiteProvider"/> implementation of <see cref="IDeploymentSource_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDeploymentSource_FileSystemSiteProvider> AddDefaultDeploymentSourceFileSystemSiteProviderAction(this IServiceAction _,
            IServiceAction<IProjectBuildOutputBinariesDirectoryPathProvider> addProjectBuildOutputBinariesDirectoryPathProvider,
            IServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            IServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = _.New<IDeploymentSource_FileSystemSiteProvider>(services => services.AddDefaultDeploymentSourceFileSystemSiteProvider(
                addProjectBuildOutputBinariesDirectoryPathProvider,
                addLocalFileSystemOperator,
                addStringlyTypedPathOperator));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestination_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDeploymentDestination_FileSystemSiteProvider> AddSecretsFileRemoteDeploymentDestinationFileSystemSiteProviderAction(this IServiceAction _,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider,
            IServiceAction<IRemoteFileSystemOperator> addRemoteFileSystemOperator,
            IServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = _.New<IDeploymentDestination_FileSystemSiteProvider>(services => services.AddSecretsFileRemoteDeploymentDestinationFileSystemSiteProvider(
                addRemoteDeploymentSecretsSerializationProvider,
                addRemoteFileSystemOperator,
                addStringlyTypedPathOperator));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SecretsFileLocalDeploymentDestinationFileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestination_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDeploymentDestination_FileSystemSiteProvider> AddSecretsFileLocalDeploymentDestinationFileSystemSiteProviderAction(this IServiceAction _,
            IServiceAction<ILocalDeploymentSecretsSerializationProvider> addLocalDeploymentSecretsSerializationProvider,
            IServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            IServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = _.New<IDeploymentDestination_FileSystemSiteProvider>(services => services.AddSecretsFileLocalDeploymentDestinationFileSystemSiteProvider(
                addLocalDeploymentSecretsSerializationProvider,
                addLocalFileSystemOperator,
                addStringlyTypedPathOperator));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="RemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider"/> implementation of <see cref="IAwsEc2ServerSecretsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAwsEc2ServerSecretsFileNameProvider> AddRemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProviderAction(this IServiceAction _,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            var serviceAction = _.New<IAwsEc2ServerSecretsFileNameProvider>(services => services.AddRemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider(
                addRemoteDeploymentSecretsSerializationProvider));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="RemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider"/> implementation of <see cref="IAwsEc2ServerHostFriendlyNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAwsEc2ServerHostFriendlyNameProvider> AddRemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProviderAction(this IServiceAction _,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            var serviceAction = _.New<IAwsEc2ServerHostFriendlyNameProvider>(services => services.AddRemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider(
                addRemoteDeploymentSecretsSerializationProvider));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DirectDeploymentDestinationSecretsFileNameProvider"/> implementation of <see cref="IDeploymentDestinationSecretsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDeploymentDestinationSecretsFileNameProvider> AddDirectDeploymentDestinationSecretsFileNameProviderAction(this IServiceAction _,
            string deploymentDestinationSecretsFileName)
        {
            var serviceAction = _.New<IDeploymentDestinationSecretsFileNameProvider>(services => services.AddDirectDeploymentDestinationSecretsFileNameProvider(
                deploymentDestinationSecretsFileName));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DefaultRemoteDeploymentSecretsSerializationProvider"/> implementation of <see cref="IRemoteDeploymentSecretsSerializationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRemoteDeploymentSecretsSerializationProvider> AddDefaultRemoteDeploymentSecretsSerializationProviderAction(this IServiceAction _,
            IServiceAction<IDeploymentDestinationSecretsFileNameProvider> addDeploymentDestinationSecretsFileNameProvider,
            IServiceAction<ISecretsDirectoryFilePathProvider> addSecretsDirectoryFilePathProvider,
            IServiceAction<IJsonFileSerializationOperator> addJsonFileSerializationOperator)
        {
            var serviceAction = _.New<IRemoteDeploymentSecretsSerializationProvider>(services => services.AddDefaultRemoteDeploymentSecretsSerializationProvider(
                addDeploymentDestinationSecretsFileNameProvider,
                addSecretsDirectoryFilePathProvider,
                addJsonFileSerializationOperator));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DefaultLocalDeploymentSecretsSerializationProvider"/> implementation of <see cref="ILocalDeploymentSecretsSerializationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ILocalDeploymentSecretsSerializationProvider> AddDefaultLocalDeploymentSecretsSerializationProviderAction(this IServiceAction _,
            IServiceAction<IDeploymentDestinationSecretsFileNameProvider> addDeploymentDestinationSecretsFileNameProvider,
            IServiceAction<ISecretsDirectoryFilePathProvider> addSecretsDirectoryFilePathProvider,
            IServiceAction<IJsonFileSerializationOperator> addJsonFileSerializationOperator)
        {
            var serviceAction = _.New<ILocalDeploymentSecretsSerializationProvider>(services => services.AddDefaultLocalDeploymentSecretsSerializationProvider(
                addDeploymentDestinationSecretsFileNameProvider,
                addSecretsDirectoryFilePathProvider,
                addJsonFileSerializationOperator));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DotnetPublishAction"/> implementation of <see cref="IPublishAction"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IPublishAction> AddDefaultDotnetPublishActionAction(this IServiceAction _,
            IServiceAction<IEntryPointProjectFilePathProvider> addEntryPointProjectFilePathProvider,
            IServiceAction<IEntryPointProjectBuildOutputPublishDirectoryPathProvider> addEntryPointProjectBuildOutputPublishDirectoryPathProvider,
            IServiceAction<IDotnetOperator> addDotnetOperator)
        {
            var serviceAction = _.New<IPublishAction>(services => services.AddDefaultDotnetPublishAction(
                addEntryPointProjectFilePathProvider,
                addEntryPointProjectBuildOutputPublishDirectoryPathProvider,
                addDotnetOperator));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestination_SecretsDirectory_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDeploymentDestination_SecretsDirectory_FileSystemSiteProvider> AddDefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProviderAction(this IServiceAction _,
            IServiceAction<IRemoteFileSystemOperator> addRemoteFileSystemOperator,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            var serviceAction = _.New<IDeploymentDestination_SecretsDirectory_FileSystemSiteProvider>(services => services.AddDefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProvider(
                addRemoteFileSystemOperator,
                addRemoteDeploymentSecretsSerializationProvider));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider"/> implementation of <see cref="IDeploymentSource_SecretsDirectory_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDeploymentSource_SecretsDirectory_FileSystemSiteProvider> AddDefaultDeploymentSource_SecretsDirectory_FileSystemSiteProviderAction(this IServiceAction _,
            IServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            IServiceAction<ISecretsDirectoryPathProvider> addSecretsDirectoryPathProvider)
        {
            var serviceAction = _.New<IDeploymentSource_SecretsDirectory_FileSystemSiteProvider>(services => services.AddDefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider(
                addLocalFileSystemOperator,
                addSecretsDirectoryPathProvider));

            return serviceAction;
        }
    }
}
