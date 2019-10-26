using System;

using R5T.Frisia.Suebia;


namespace R5T.Antium.Default
{
    public class RemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider : IAwsEc2ServerSecretsFileNameProvider
    {
        private RemoteDeploymentSecretsSerialization RemoteDeploymentSecretsSerialization { get; }


        public RemoteDeploymentSerializationAwsEc2ServerSecretsFileNameProvider(
            RemoteDeploymentSecretsSerialization remoteDeploymentSecretsSerialization)
        {
            this.RemoteDeploymentSecretsSerialization = remoteDeploymentSecretsSerialization;
        }

        public string GetAwsEc2ServerSecretsFileName()
        {
            var output = this.RemoteDeploymentSecretsSerialization.AwsEC2ServerSecretsFilename;
            return output;
        }
    }
}
