using System;

using R5T.Frisia.Suebia;

using R5T.T0064;


namespace R5T.Antium.Default
{
    [ServiceImplementationMarker]
    public class RemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider : IAwsEc2ServerSecretsFileNameProvider, IServiceImplementation
    {
        private IRemoteDeploymentSecretsSerializationProvider RemoteDeploymentSecretsSerializationProvider { get; }


        public RemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider(
            IRemoteDeploymentSecretsSerializationProvider remoteDeploymentSecretsSerializationProvider)
        {
            this.RemoteDeploymentSecretsSerializationProvider = remoteDeploymentSecretsSerializationProvider;
        }

        public string GetAwsEc2ServerSecretsFileName()
        {
            var remoteDeploymentSecretsSerialization = this.RemoteDeploymentSecretsSerializationProvider.GetRemoteDeploymentSecretsSerialization();

            var output = remoteDeploymentSecretsSerialization.AwsEC2ServerSecretsFilename;
            return output;
        }
    }
}
