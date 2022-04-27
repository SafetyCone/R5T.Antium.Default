using System;

using R5T.Jutland;
using R5T.Suebia;

using R5T.T0064;


namespace R5T.Antium.Default
{
    [ServiceImplementationMarker]
    public class DefaultLocalDeploymentSecretsSerializationProvider : ILocalDeploymentSecretsSerializationProvider, IServiceImplementation
    {
        private IDeploymentDestinationSecretsFileNameProvider DeploymentDestinationSecretsFileNameProvider { get; }
        private ISecretsDirectoryFilePathProvider SecretsDirectoryFilePathProvider { get; }
        private IJsonFileSerializationOperator JsonFileSerializationOperator { get; }


        public DefaultLocalDeploymentSecretsSerializationProvider(
            IDeploymentDestinationSecretsFileNameProvider deploymentDestinationSecretsFileNameProvider,
            ISecretsDirectoryFilePathProvider secretsDirectoryFilePathProvider,
            IJsonFileSerializationOperator jsonFileSerializationOperator)
        {
            this.DeploymentDestinationSecretsFileNameProvider = deploymentDestinationSecretsFileNameProvider;
            this.SecretsDirectoryFilePathProvider = secretsDirectoryFilePathProvider;
            this.JsonFileSerializationOperator = jsonFileSerializationOperator;
        }

        public LocalDeploymentSecretsSerialization GetLocalDeploymentSecretsSerialization()
        {
            var deploymentDestinationSecretsFileName = this.DeploymentDestinationSecretsFileNameProvider.GetDeploymentDestinationSecretsFileName();

            var deploymentDestinationSecretsFilePath = this.SecretsDirectoryFilePathProvider.GetSecretsFilePath(deploymentDestinationSecretsFileName);

            // Load the type from JSON and get the local directory path.
            var localDeploymentSecretsSerialization = this.JsonFileSerializationOperator.Deserialize<LocalDeploymentSecretsSerialization>(deploymentDestinationSecretsFilePath);
            return localDeploymentSecretsSerialization;
        }
    }
}
