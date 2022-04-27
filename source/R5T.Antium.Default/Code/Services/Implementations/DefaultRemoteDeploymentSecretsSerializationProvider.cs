using System;

using R5T.Jutland;
using R5T.Suebia;

using R5T.T0064;


namespace R5T.Antium.Default
{
    [ServiceImplementationMarker]
    public class DefaultRemoteDeploymentSecretsSerializationProvider : IRemoteDeploymentSecretsSerializationProvider, IServiceImplementation
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
