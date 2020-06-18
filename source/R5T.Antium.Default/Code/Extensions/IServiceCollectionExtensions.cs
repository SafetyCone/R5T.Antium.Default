using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Frisia.Suebia;
using R5T.Gepidia.Local;
using R5T.Gepidia.Remote;
using R5T.Jutland;
using R5T.Lombardy;
using R5T.Norsica;
using R5T.Pompeii;
using R5T.Suebia;


namespace R5T.Antium.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="DefaultDeploymentSourceFileSystemSiteProvider"/> implementation of <see cref="IDeploymentSource_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultDeploymentSourceFileSystemSiteProvider(this IServiceCollection services,
            IServiceAction<IProjectBuildOutputBinariesDirectoryPathProvider> addProjectBuildOutputBinariesDirectoryPathProvider,
            IServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            IServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            services
                .AddSingleton<IDeploymentSource_FileSystemSiteProvider, DefaultDeploymentSourceFileSystemSiteProvider>()
                .RunServiceAction(addProjectBuildOutputBinariesDirectoryPathProvider)
                .RunServiceAction(addLocalFileSystemOperator)
                .RunServiceAction(addStringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultDeploymentSourceFileSystemSiteProvider"/> implementation of <see cref="IDeploymentSource_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDeploymentSource_FileSystemSiteProvider> AddDefaultDeploymentSourceFileSystemSiteProviderAction(this IServiceCollection services,
            IServiceAction<IProjectBuildOutputBinariesDirectoryPathProvider> addProjectBuildOutputBinariesDirectoryPathProvider,
            IServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            IServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = new ServiceAction<IDeploymentSource_FileSystemSiteProvider>(() => services.AddDefaultDeploymentSourceFileSystemSiteProvider(
                addProjectBuildOutputBinariesDirectoryPathProvider,
                addLocalFileSystemOperator,
                addStringlyTypedPathOperator));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestination_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSecretsFileRemoteDeploymentDestinationFileSystemSiteProvider(this IServiceCollection services,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider,
            IServiceAction<IRemoteFileSystemOperator> addRemoteFileSystemOperator,
            IServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            services
                .AddSingleton<IDeploymentDestination_FileSystemSiteProvider, SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider>()
                .RunServiceAction(addRemoteDeploymentSecretsSerializationProvider)
                .RunServiceAction(addRemoteFileSystemOperator)
                .RunServiceAction(addStringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestination_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDeploymentDestination_FileSystemSiteProvider> AddSecretsFileRemoteDeploymentDestinationFileSystemSiteProviderAction(this IServiceCollection services,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider,
            IServiceAction<IRemoteFileSystemOperator> addRemoteFileSystemOperator,
            IServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = new ServiceAction<IDeploymentDestination_FileSystemSiteProvider>(() => services.AddSecretsFileRemoteDeploymentDestinationFileSystemSiteProvider(
                addRemoteDeploymentSecretsSerializationProvider,
                addRemoteFileSystemOperator,
                addStringlyTypedPathOperator));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SecretsFileLocalDeploymentDestinationFileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestination_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSecretsFileLocalDeploymentDestinationFileSystemSiteProvider(this IServiceCollection services,
            IServiceAction<ILocalDeploymentSecretsSerializationProvider> addLocalDeploymentSecretsSerializationProvider,
            IServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            IServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            services
                .AddSingleton<IDeploymentDestination_FileSystemSiteProvider, SecretsFileLocalDeploymentDestinationFileSystemSiteProvider>()
                .RunServiceAction(addLocalDeploymentSecretsSerializationProvider)
                .RunServiceAction(addLocalFileSystemOperator)
                .RunServiceAction(addStringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SecretsFileLocalDeploymentDestinationFileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestination_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDeploymentDestination_FileSystemSiteProvider> AddSecretsFileLocalDeploymentDestinationFileSystemSiteProviderAction(this IServiceCollection services,
            IServiceAction<ILocalDeploymentSecretsSerializationProvider> addLocalDeploymentSecretsSerializationProvider,
            IServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            IServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = new ServiceAction<IDeploymentDestination_FileSystemSiteProvider>(() => services.AddSecretsFileLocalDeploymentDestinationFileSystemSiteProvider(
                addLocalDeploymentSecretsSerializationProvider,
                addLocalFileSystemOperator,
                addStringlyTypedPathOperator));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="RemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider"/> implementation of <see cref="IAwsEc2ServerSecretsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider(this IServiceCollection services,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            services
                .AddSingleton<IAwsEc2ServerSecretsFileNameProvider, RemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider>()
                .RunServiceAction(addRemoteDeploymentSecretsSerializationProvider)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="RemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider"/> implementation of <see cref="IAwsEc2ServerSecretsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAwsEc2ServerSecretsFileNameProvider> AddRemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProviderAction(this IServiceCollection services,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            var serviceAction = new ServiceAction<IAwsEc2ServerSecretsFileNameProvider>(() => services.AddRemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider(
                addRemoteDeploymentSecretsSerializationProvider));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="RemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider"/> implementation of <see cref="IAwsEc2ServerHostFriendlyNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider(this IServiceCollection services,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            services
                .AddSingleton<IAwsEc2ServerHostFriendlyNameProvider, RemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider>()
                .RunServiceAction(addRemoteDeploymentSecretsSerializationProvider)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="RemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider"/> implementation of <see cref="IAwsEc2ServerHostFriendlyNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAwsEc2ServerHostFriendlyNameProvider> AddRemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProviderAction(this IServiceCollection services,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            var serviceAction = new ServiceAction<IAwsEc2ServerHostFriendlyNameProvider>(() => services.AddRemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider(
                addRemoteDeploymentSecretsSerializationProvider));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DirectDeploymentDestinationSecretsFileNameProvider"/> implementation of <see cref="IDeploymentDestinationSecretsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDirectDeploymentDestinationSecretsFileNameProvider(this IServiceCollection services, string deploymentDestinationSecretsFileName)
        {
            services
                .AddSingleton<IDeploymentDestinationSecretsFileNameProvider, DirectDeploymentDestinationSecretsFileNameProvider>((serviceProvider) =>
                {
                    var directDeploymentDestinationSecretsFileNameProvider = new DirectDeploymentDestinationSecretsFileNameProvider(deploymentDestinationSecretsFileName);
                    return directDeploymentDestinationSecretsFileNameProvider;
                })
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DirectDeploymentDestinationSecretsFileNameProvider"/> implementation of <see cref="IDeploymentDestinationSecretsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDeploymentDestinationSecretsFileNameProvider> AddDirectDeploymentDestinationSecretsFileNameProviderAction(this IServiceCollection services, string deploymentDestinationSecretsFileName)
        {
            var serviceAction = new ServiceAction<IDeploymentDestinationSecretsFileNameProvider>(() => services.AddDirectDeploymentDestinationSecretsFileNameProvider(deploymentDestinationSecretsFileName));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DefaultRemoteDeploymentSecretsSerializationProvider"/> implementation of <see cref="IRemoteDeploymentSecretsSerializationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultRemoteDeploymentSecretsSerializationProvider(this IServiceCollection services,
            IServiceAction<IDeploymentDestinationSecretsFileNameProvider> addDeploymentDestinationSecretsFileNameProvider,
            IServiceAction<ISecretsDirectoryFilePathProvider> addSecretsDirectoryFilePathProvider,
            IServiceAction<IJsonFileSerializationOperator> addJsonFileSerializationOperator)
        {
            services
                .AddSingleton<IRemoteDeploymentSecretsSerializationProvider, DefaultRemoteDeploymentSecretsSerializationProvider>()
                .RunServiceAction(addDeploymentDestinationSecretsFileNameProvider)
                .RunServiceAction(addSecretsDirectoryFilePathProvider)
                .RunServiceAction(addJsonFileSerializationOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultRemoteDeploymentSecretsSerializationProvider"/> implementation of <see cref="IRemoteDeploymentSecretsSerializationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IRemoteDeploymentSecretsSerializationProvider> AddDefaultRemoteDeploymentSecretsSerializationProviderAction(this IServiceCollection services,
            IServiceAction<IDeploymentDestinationSecretsFileNameProvider> addDeploymentDestinationSecretsFileNameProvider,
            IServiceAction<ISecretsDirectoryFilePathProvider> addSecretsDirectoryFilePathProvider,
            IServiceAction<IJsonFileSerializationOperator> addJsonFileSerializationOperator)
        {
            var serviceAction = new ServiceAction<IRemoteDeploymentSecretsSerializationProvider>(() => services.AddDefaultRemoteDeploymentSecretsSerializationProvider(
                addDeploymentDestinationSecretsFileNameProvider,
                addSecretsDirectoryFilePathProvider,
                addJsonFileSerializationOperator));
            return serviceAction;
        }



        /// <summary>
        /// Adds the <see cref="DefaultLocalDeploymentSecretsSerializationProvider"/> implementation of <see cref="ILocalDeploymentSecretsSerializationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultLocalDeploymentSecretsSerializationProvider(this IServiceCollection services,
            IServiceAction<IDeploymentDestinationSecretsFileNameProvider> addDeploymentDestinationSecretsFileNameProvider,
            IServiceAction<ISecretsDirectoryFilePathProvider> addSecretsDirectoryFilePathProvider,
            IServiceAction<IJsonFileSerializationOperator> addJsonFileSerializationOperator)
        {
            services
                .AddSingleton<ILocalDeploymentSecretsSerializationProvider, DefaultLocalDeploymentSecretsSerializationProvider>()
                .RunServiceAction(addDeploymentDestinationSecretsFileNameProvider)
                .RunServiceAction(addSecretsDirectoryFilePathProvider)
                .RunServiceAction(addJsonFileSerializationOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultLocalDeploymentSecretsSerializationProvider"/> implementation of <see cref="ILocalDeploymentSecretsSerializationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ILocalDeploymentSecretsSerializationProvider> AddDefaultLocalDeploymentSecretsSerializationProviderAction(this IServiceCollection services,
            IServiceAction<IDeploymentDestinationSecretsFileNameProvider> addDeploymentDestinationSecretsFileNameProvider,
            IServiceAction<ISecretsDirectoryFilePathProvider> addSecretsDirectoryFilePathProvider,
            IServiceAction<IJsonFileSerializationOperator> addJsonFileSerializationOperator)
        {
            var serviceAction = new ServiceAction<ILocalDeploymentSecretsSerializationProvider>(() => services.AddDefaultLocalDeploymentSecretsSerializationProvider(
                addDeploymentDestinationSecretsFileNameProvider,
                addSecretsDirectoryFilePathProvider,
                addJsonFileSerializationOperator));
            return serviceAction;
        }



        /// <summary>
        /// Adds the <see cref="DotnetPublishAction"/> implementation of <see cref="IPublishAction"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultDotnetPublishAction(this IServiceCollection services,
            IServiceAction<IEntryPointProjectFilePathProvider> addEntryPointProjectFilePathProvider,
            IServiceAction<IEntryPointProjectBuildOutputPublishDirectoryPathProvider> addEntryPointProjectBuildOutputPublishDirectoryPathProvider,
            IServiceAction<IDotnetOperator> addDotnetOperator)
        {
            services
                .AddSingleton<IPublishAction, DotnetPublishAction>()
                .RunServiceAction(addEntryPointProjectFilePathProvider)
                .RunServiceAction(addEntryPointProjectBuildOutputPublishDirectoryPathProvider)
                .RunServiceAction(addDotnetOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DotnetPublishAction"/> implementation of <see cref="IPublishAction"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IPublishAction> AddDefaultDotnetPublishActionAction(this IServiceCollection services,
            IServiceAction<IEntryPointProjectFilePathProvider> addEntryPointProjectFilePathProvider,
            IServiceAction<IEntryPointProjectBuildOutputPublishDirectoryPathProvider> addEntryPointProjectBuildOutputPublishDirectoryPathProvider,
            IServiceAction<IDotnetOperator> addDotnetOperator)
        {
            var serviceAction = new ServiceAction<IPublishAction>(() => services.AddDefaultDotnetPublishAction(
                addEntryPointProjectFilePathProvider,
                addEntryPointProjectBuildOutputPublishDirectoryPathProvider,
                addDotnetOperator));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestination_SecretsDirectory_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProvider(this IServiceCollection services,
            IServiceAction<IRemoteFileSystemOperator> addRemoteFileSystemOperator,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            services
                .AddSingleton<IDeploymentDestination_SecretsDirectory_FileSystemSiteProvider, DefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProvider>()
                .RunServiceAction(addRemoteFileSystemOperator)
                .RunServiceAction(addRemoteDeploymentSecretsSerializationProvider)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestination_SecretsDirectory_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDeploymentDestination_SecretsDirectory_FileSystemSiteProvider> AddDefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProviderAction(this IServiceCollection services,
            IServiceAction<IRemoteFileSystemOperator> addRemoteFileSystemOperator,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            var serviceAction = new ServiceAction<IDeploymentDestination_SecretsDirectory_FileSystemSiteProvider>(() => services.AddDefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProvider(
                addRemoteFileSystemOperator,
                addRemoteDeploymentSecretsSerializationProvider));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider"/> implementation of <see cref="IDeploymentSource_SecretsDirectory_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider(this IServiceCollection services,
            IServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            IServiceAction<ISecretsDirectoryPathProvider> addSecretsDirectoryPathProvider)
        {
            services
                .AddSingleton<IDeploymentSource_SecretsDirectory_FileSystemSiteProvider, DefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider>()
                .RunServiceAction(addLocalFileSystemOperator)
                .RunServiceAction(addSecretsDirectoryPathProvider)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider"/> implementation of <see cref="IDeploymentSource_SecretsDirectory_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDeploymentSource_SecretsDirectory_FileSystemSiteProvider> AddDefaultDeploymentSource_SecretsDirectory_FileSystemSiteProviderAction(this IServiceCollection services,
            IServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            IServiceAction<ISecretsDirectoryPathProvider> addSecretsDirectoryPathProvider)
        {
            var serviceAction = new ServiceAction<IDeploymentSource_SecretsDirectory_FileSystemSiteProvider>(() => services.AddDefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider(
                addLocalFileSystemOperator,
                addSecretsDirectoryPathProvider));
            return serviceAction;
        }
    }
}
