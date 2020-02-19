﻿using System;

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
        /// Adds the <see cref="DefaultDeploymentSourceFileSystemSiteProvider"/> implementation of <see cref="IDeploymentSourceFileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultDeploymentSourceFileSystemSiteProvider(this IServiceCollection services,
            ServiceAction<IProjectBuildOutputBinariesDirectoryPathProvider> addProjectBuildOutputBinariesDirectoryPathProvider,
            ServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            services
                .AddSingleton<IDeploymentSourceFileSystemSiteProvider, DefaultDeploymentSourceFileSystemSiteProvider>()
                .RunServiceAction(addProjectBuildOutputBinariesDirectoryPathProvider)
                .RunServiceAction(addLocalFileSystemOperator)
                .RunServiceAction(addStringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultDeploymentSourceFileSystemSiteProvider"/> implementation of <see cref="IDeploymentSourceFileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IDeploymentSourceFileSystemSiteProvider> AddDefaultDeploymentSourceFileSystemSiteProviderAction(this IServiceCollection services,
            ServiceAction<IProjectBuildOutputBinariesDirectoryPathProvider> addProjectBuildOutputBinariesDirectoryPathProvider,
            ServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = new ServiceAction<IDeploymentSourceFileSystemSiteProvider>(() => services.AddDefaultDeploymentSourceFileSystemSiteProvider(
                addProjectBuildOutputBinariesDirectoryPathProvider,
                addLocalFileSystemOperator,
                addStringlyTypedPathOperator));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestinationFileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSecretsFileRemoteDeploymentDestinationFileSystemSiteProvider(this IServiceCollection services,
            ServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider,
            ServiceAction<IRemoteFileSystemOperator> addRemoteFileSystemOperator,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            services
                .AddSingleton<IDeploymentDestinationFileSystemSiteProvider, SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider>()
                .RunServiceAction(addRemoteDeploymentSecretsSerializationProvider)
                .RunServiceAction(addRemoteFileSystemOperator)
                .RunServiceAction(addStringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SecretsFileRemoteDeploymentDestinationFileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestinationFileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IDeploymentDestinationFileSystemSiteProvider> AddSecretsFileRemoteDeploymentDestinationFileSystemSiteProviderAction(this IServiceCollection services,
            ServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider,
            ServiceAction<IRemoteFileSystemOperator> addRemoteFileSystemOperator,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = new ServiceAction<IDeploymentDestinationFileSystemSiteProvider>(() => services.AddSecretsFileRemoteDeploymentDestinationFileSystemSiteProvider(
                addRemoteDeploymentSecretsSerializationProvider,
                addRemoteFileSystemOperator,
                addStringlyTypedPathOperator));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="SecretsFileLocalDeploymentDestinationFileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestinationFileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddSecretsFileLocalDeploymentDestinationFileSystemSiteProvider(this IServiceCollection services,
            ServiceAction<ILocalDeploymentSecretsSerializationProvider> addLocalDeploymentSecretsSerializationProvider,
            ServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            services
                .AddSingleton<IDeploymentDestinationFileSystemSiteProvider, SecretsFileLocalDeploymentDestinationFileSystemSiteProvider>()
                .RunServiceAction(addLocalDeploymentSecretsSerializationProvider)
                .RunServiceAction(addLocalFileSystemOperator)
                .RunServiceAction(addStringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="SecretsFileLocalDeploymentDestinationFileSystemSiteProvider"/> implementation of <see cref="IDeploymentDestinationFileSystemSiteProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IDeploymentDestinationFileSystemSiteProvider> AddSecretsFileLocalDeploymentDestinationFileSystemSiteProviderAction(this IServiceCollection services,
            ServiceAction<ILocalDeploymentSecretsSerializationProvider> addLocalDeploymentSecretsSerializationProvider,
            ServiceAction<ILocalFileSystemOperator> addLocalFileSystemOperator,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = new ServiceAction<IDeploymentDestinationFileSystemSiteProvider>(() => services.AddSecretsFileLocalDeploymentDestinationFileSystemSiteProvider(
                addLocalDeploymentSecretsSerializationProvider,
                addLocalFileSystemOperator,
                addStringlyTypedPathOperator));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="RemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider"/> implementation of <see cref="IAwsEc2ServerSecretsFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider(this IServiceCollection services,
            ServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
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
        public static ServiceAction<IAwsEc2ServerSecretsFileNameProvider> AddRemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProviderAction(this IServiceCollection services,
            ServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
        {
            var serviceAction = new ServiceAction<IAwsEc2ServerSecretsFileNameProvider>(() => services.AddRemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider(
                addRemoteDeploymentSecretsSerializationProvider));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="RemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider"/> implementation of <see cref="IAwsEc2ServerHostFriendlyNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddRemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider(this IServiceCollection services,
            ServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
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
        public static ServiceAction<IAwsEc2ServerHostFriendlyNameProvider> AddRemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProviderAction(this IServiceCollection services,
            ServiceAction<IRemoteDeploymentSecretsSerializationProvider> addRemoteDeploymentSecretsSerializationProvider)
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
        public static ServiceAction<IDeploymentDestinationSecretsFileNameProvider> AddDirectDeploymentDestinationSecretsFileNameProviderAction(this IServiceCollection services, string deploymentDestinationSecretsFileName)
        {
            var serviceAction = new ServiceAction<IDeploymentDestinationSecretsFileNameProvider>(() => services.AddDirectDeploymentDestinationSecretsFileNameProvider(deploymentDestinationSecretsFileName));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DefaultRemoteDeploymentSecretsSerializationProvider"/> implementation of <see cref="IRemoteDeploymentSecretsSerializationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultRemoteDeploymentSecretsSerializationProvider(this IServiceCollection services,
            ServiceAction<IDeploymentDestinationSecretsFileNameProvider> addDeploymentDestinationSecretsFileNameProvider,
            ServiceAction<ISecretsFilePathProvider> addSecretsFilePathProvider,
            ServiceAction<IJsonFileSerializationOperator> addJsonFileSerializationOperator)
        {
            services
                .AddSingleton<IRemoteDeploymentSecretsSerializationProvider, DefaultRemoteDeploymentSecretsSerializationProvider>()
                .RunServiceAction(addDeploymentDestinationSecretsFileNameProvider)
                .RunServiceAction(addSecretsFilePathProvider)
                .RunServiceAction(addJsonFileSerializationOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultRemoteDeploymentSecretsSerializationProvider"/> implementation of <see cref="IRemoteDeploymentSecretsSerializationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IRemoteDeploymentSecretsSerializationProvider> AddDefaultRemoteDeploymentSecretsSerializationProviderAction(this IServiceCollection services,
            ServiceAction<IDeploymentDestinationSecretsFileNameProvider> addDeploymentDestinationSecretsFileNameProvider,
            ServiceAction<ISecretsFilePathProvider> addSecretsFilePathProvider,
            ServiceAction<IJsonFileSerializationOperator> addJsonFileSerializationOperator)
        {
            var serviceAction = new ServiceAction<IRemoteDeploymentSecretsSerializationProvider>(() => services.AddDefaultRemoteDeploymentSecretsSerializationProvider(
                addDeploymentDestinationSecretsFileNameProvider,
                addSecretsFilePathProvider,
                addJsonFileSerializationOperator));
            return serviceAction;
        }



        /// <summary>
        /// Adds the <see cref="DefaultLocalDeploymentSecretsSerializationProvider"/> implementation of <see cref="ILocalDeploymentSecretsSerializationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultLocalDeploymentSecretsSerializationProvider(this IServiceCollection services,
            ServiceAction<IDeploymentDestinationSecretsFileNameProvider> addDeploymentDestinationSecretsFileNameProvider,
            ServiceAction<ISecretsFilePathProvider> addSecretsFilePathProvider,
            ServiceAction<IJsonFileSerializationOperator> addJsonFileSerializationOperator)
        {
            services
                .AddSingleton<ILocalDeploymentSecretsSerializationProvider, DefaultLocalDeploymentSecretsSerializationProvider>()
                .RunServiceAction(addDeploymentDestinationSecretsFileNameProvider)
                .RunServiceAction(addSecretsFilePathProvider)
                .RunServiceAction(addJsonFileSerializationOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultLocalDeploymentSecretsSerializationProvider"/> implementation of <see cref="ILocalDeploymentSecretsSerializationProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ILocalDeploymentSecretsSerializationProvider> AddDefaultLocalDeploymentSecretsSerializationProviderAction(this IServiceCollection services,
            ServiceAction<IDeploymentDestinationSecretsFileNameProvider> addDeploymentDestinationSecretsFileNameProvider,
            ServiceAction<ISecretsFilePathProvider> addSecretsFilePathProvider,
            ServiceAction<IJsonFileSerializationOperator> addJsonFileSerializationOperator)
        {
            var serviceAction = new ServiceAction<ILocalDeploymentSecretsSerializationProvider>(() => services.AddDefaultLocalDeploymentSecretsSerializationProvider(
                addDeploymentDestinationSecretsFileNameProvider,
                addSecretsFilePathProvider,
                addJsonFileSerializationOperator));
            return serviceAction;
        }



        /// <summary>
        /// Adds the <see cref="DotnetPublicationOperator"/> implementation of <see cref="IPublicationOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultDotnetPublicationOperator(this IServiceCollection services,
            ServiceAction<IEntryPointProjectFilePathProvider> addEntryPointProjectFilePathProvider,
            ServiceAction<IEntryPointProjectBuildOutputPublishDirectoryPathProvider> addEntryPointProjectBuildOutputPublishDirectoryPathProvider,
            ServiceAction<IDotnetOperator> addDotnetOperator)
        {
            services
                .AddSingleton<IPublicationOperator, DotnetPublicationOperator>()
                .RunServiceAction(addEntryPointProjectFilePathProvider)
                .RunServiceAction(addEntryPointProjectBuildOutputPublishDirectoryPathProvider)
                .RunServiceAction(addDotnetOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DotnetPublicationOperator"/> implementation of <see cref="IPublicationOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IPublicationOperator> AddDefaultDotnetPublicationOperatorAction(this IServiceCollection services,
            ServiceAction<IEntryPointProjectFilePathProvider> addEntryPointProjectFilePathProvider,
            ServiceAction<IEntryPointProjectBuildOutputPublishDirectoryPathProvider> addEntryPointProjectBuildOutputPublishDirectoryPathProvider,
            ServiceAction<IDotnetOperator> addDotnetOperator)
        {
            var serviceAction = new ServiceAction<IPublicationOperator>(() => services.AddDefaultDotnetPublicationOperator(
                addEntryPointProjectFilePathProvider,
                addEntryPointProjectBuildOutputPublishDirectoryPathProvider,
                addDotnetOperator));
            return serviceAction;
        }
    }
}