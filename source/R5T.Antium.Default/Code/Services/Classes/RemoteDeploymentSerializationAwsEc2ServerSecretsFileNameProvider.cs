using System;

using R5T.Frisia.Suebia;


namespace R5T.Antium.Default
{
    public class RemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider : IAwsEc2ServerSecretsFileNameProvider
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
