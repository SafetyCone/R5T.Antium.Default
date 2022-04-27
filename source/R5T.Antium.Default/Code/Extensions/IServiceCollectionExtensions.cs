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
    public static partial class IServiceCollectionExtensions
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
                .Run(addProjectBuildOutputBinariesDirectoryPathProvider)
                .Run(addLocalFileSystemOperator)
                .Run(addStringlyTypedPathOperator)
                .AddSingleton<IDeploymentSource_FileSystemSiteProvider, DefaultDeploymentSourceFileSystemSiteProvider>()
                ;

            return services;
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
                .Run(addRemoteDeploymentSecretsSerializationProvider)
                .Run(addRemoteFileSystemOperator)
                .Run(addStringlyTypedPathOperator)
                .AddSingleton<IDeploymentDestination_FileSystemSiteProvider, SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider>()
                ;

            return services;
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
                .Run(addLocalDeploymentSecretsSerializationProvider)
                .Run(addLocalFileSystemOperator)
                .Run(addStringlyTypedPathOperator)
                .AddSingleton<IDeploymentDestination_FileSystemSiteProvider, SecretsFileLocalDeploymentDestinationFileSystemSiteProvider>()
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="RemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider"/> implementation of <see cref="IAwsEc2ServerSecretsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider(this IServiceCollection services,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            services
                .Run(addRemoteDeploymentSecretsSerializationProvider)
                .AddSingleton<IAwsEc2ServerSecretsFileNameProvider, RemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider>()
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="RemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider"/> implementation of <see cref="IAwsEc2ServerHostFriendlyNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider(this IServiceCollection services,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            services
                .Run(addRemoteDeploymentSecretsSerializationProvider)
                .AddSingleton<IAwsEc2ServerHostFriendlyNameProvider, RemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider>()
                ;

            return services;
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
        /// Adds the <see cref="DefaultRemoteDeploymentSecretsSerializationProvider"/> implementation of <see cref="IRemoteDeploymentSecretsSerializationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultRemoteDeploymentSecretsSerializationProvider(this IServiceCollection services,
            IServiceAction<IDeploymentDestinationSecretsFileNameProvider> addDeploymentDestinationSecretsFileNameProvider,
            IServiceAction<ISecretsDirectoryFilePathProvider> addSecretsDirectoryFilePathProvider,
            IServiceAction<IJsonFileSerializationOperator> addJsonFileSerializationOperator)
        {
            services
                .Run(addDeploymentDestinationSecretsFileNameProvider)
                .Run(addSecretsDirectoryFilePathProvider)
                .Run(addJsonFileSerializationOperator)
                .AddSingleton<IRemoteDeploymentSecretsSerializationProvider, DefaultRemoteDeploymentSecretsSerializationProvider>()
                ;

            return services;
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
                .Run(addDeploymentDestinationSecretsFileNameProvider)
                .Run(addSecretsDirectoryFilePathProvider)
                .Run(addJsonFileSerializationOperator)
                .AddSingleton<ILocalDeploymentSecretsSerializationProvider, DefaultLocalDeploymentSecretsSerializationProvider>()
                ;

            return services;
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
                .Run(addEntryPointProjectFilePathProvider)
                .Run(addEntryPointProjectBuildOutputPublishDirectoryPathProvider)
                .Run(addDotnetOperator)
                .AddSingleton<IPublishAction, DotnetPublishAction>()
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestination_SecretsDirectory_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProvider(this IServiceCollection services,
            IServiceAction<IRemoteFileSystemOperator> addRemoteFileSystemOperator,
            IServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            services
                .Run(addRemoteFileSystemOperator)
                .Run(addRemoteDeploymentSecretsSerializationProvider)
                .AddSingleton<IDeploymentDestination_SecretsDirectory_FileSystemSiteProvider, DefaultRemoteDeploymentDestination_SecretsDirectory_FileSystemSiteProvider>()
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider"/> implementation of <see cref="IDeploymentSource_SecretsDirectory_FileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider(this IServiceCollection services,
            IServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            IServiceAction<ISecretsDirectoryPathProvider> addSecretsDirectoryPathProvider)
        {
            services
                .Run(addLocalFileSystemOperator)
                .Run(addSecretsDirectoryPathProvider)
                .AddSingleton<IDeploymentSource_SecretsDirectory_FileSystemSiteProvider, DefaultDeploymentSource_SecretsDirectory_FileSystemSiteProvider>()
                ;

            return services;
        }
    }
}
