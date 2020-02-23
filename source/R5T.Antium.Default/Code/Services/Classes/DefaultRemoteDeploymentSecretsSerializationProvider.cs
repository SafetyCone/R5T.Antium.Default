using System;

using R5T.Jutland;
using R5T.Suebia;


namespace R5T.Antium.Default
{
    public class DefaultRemoteDeploymentSecretsSerializationProvider : IRemoteDeploymentSecretsSerializationProvider
    {
        private IDeploymentDestinationSecretsFileNameProvider DeploymentDestinationSecretsFileNameProvider { get; }
        private ISecretsDirectoryFilePathProvider SecretsDirectoryFilePathProvider { get; }
        private IJsonFileSerializationOperator JsonFileSerializationOperator { get; }


        public DefaultRemoteDeploymentSecretsSerializationProvider(
            IDeploymentDestinationSecretsFileNameProvider deploymentDestinationSecretsFileNameProvider,
            ISecretsDirectoryFilePathProvider secretsDirectoryFilePathProvider,
            IJsonFileSerializationOperator jsonFileSerializationOperator)
        {
            this.DeploymentDestinationSecretsFileNameProvider = deploymentDestinationSecretsFileNameProvider;
            this.SecretsDirectoryFilePathProvider = secretsDirectoryFilePathProvider;
            this.JsonFileSerializationOperator = jsonFileSerializationOperator;
        }

        public RemoteDeploymentSecretsSerialization GetRemoteDeploymentSecretsSerialization()
        {
            var deploymentDestinationSecretsFileName = this.DeploymentDestinationSecretsFileNameProvider.GetDeploymentDestinationSecretsFileName();

            var deploymentDestinatinoSecretsFilePath = this.SecretsDirectoryFilePathProvider.GetSecretsFilePath(deploymentDestinationSecretsFileName);

            var serialization = this.JsonFileSerializationOperator.Deserialize<RemoteDeploymentSecretsSerialization>(deploymentDestinatinoSecretsFilePath);
            return serialization;
        }
    }
}
