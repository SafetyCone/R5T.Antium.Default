using System;

using R5T.Jutland;
using R5T.Suebia;


namespace R5T.Antium.Default
{
    public class DefaultLocalDeploymentSecretsSerializationProvider : ILocalDeploymentSecretsSerializationProvider
    {
        private IDeploymentDestinationSecretsFileNameProvider DeploymentDestinationSecretsFileNameProvider { get; }
        private ISecretsFilePathProvider SecretsFilePathProvider { get; }
        private IJsonFileSerializationOperator JsonFileSerializationOperator { get; }


        public DefaultLocalDeploymentSecretsSerializationProvider(
            IDeploymentDestinationSecretsFileNameProvider deploymentDestinationSecretsFileNameProvider,
            ISecretsFilePathProvider secretsFilePathProvider,
            IJsonFileSerializationOperator jsonFileSerializationOperator)
        {
            this.DeploymentDestinationSecretsFileNameProvider = deploymentDestinationSecretsFileNameProvider;
            this.SecretsFilePathProvider = secretsFilePathProvider;
            this.JsonFileSerializationOperator = jsonFileSerializationOperator;
        }

        public LocalDeploymentSecretsSerialization GetLocalDeploymentSecretsSerialization()
        {
            var deploymentDestinationSecretsFileName = this.DeploymentDestinationSecretsFileNameProvider.GetDeploymentDestinationSecretsFileName();

            var deploymentDestinationSecretsFilePath = this.SecretsFilePathProvider.GetSecretsFilePath(deploymentDestinationSecretsFileName);

            // Load the type from JSON and get the local directory path.
            var localDeploymentSecretsSerialization = this.JsonFileSerializationOperator.Deserialize<LocalDeploymentSecretsSerialization>(deploymentDestinationSecretsFilePath);
            return localDeploymentSecretsSerialization;
        }
    }
}
