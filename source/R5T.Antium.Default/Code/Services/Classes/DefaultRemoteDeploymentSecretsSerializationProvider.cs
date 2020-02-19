using System;

using R5T.Jutland;
using R5T.Suebia;


namespace R5T.Antium.Default
{
    public class DefaultRemoteDeploymentSecretsSerializationProvider : IRemoteDeploymentSecretsSerializationProvider
    {
        private IDeploymentDestinationSecretsFileNameProvider DeploymentDestinationSecretsFileNameProvider { get; }
        private ISecretsFilePathProvider SecretsFilePathProvider { get; }
        private IJsonFileSerializationOperator JsonFileSerializationOperator { get; }


        public DefaultRemoteDeploymentSecretsSerializationProvider(
            IDeploymentDestinationSecretsFileNameProvider deploymentDestinationSecretsFileNameProvider,
            ISecretsFilePathProvider secretsFilePathProvider,
            IJsonFileSerializationOperator jsonFileSerializationOperator)
        {
            this.DeploymentDestinationSecretsFileNameProvider = deploymentDestinationSecretsFileNameProvider;
            this.SecretsFilePathProvider = secretsFilePathProvider;
            this.JsonFileSerializationOperator = jsonFileSerializationOperator;
        }

        public RemoteDeploymentSecretsSerialization GetRemoteDeploymentSecretsSerialization()
        {
            var deploymentDestinationSecretsFileName = this.DeploymentDestinationSecretsFileNameProvider.GetDeploymentDestinationSecretsFileName();

            var deploymentDestinatinoSecretsFilePath = this.SecretsFilePathProvider.GetSecretsFilePath(deploymentDestinationSecretsFileName);

            var serialization = this.JsonFileSerializationOperator.Deserialize<RemoteDeploymentSecretsSerialization>(deploymentDestinatinoSecretsFilePath);
            return serialization;
        }
    }
}
