using System;

using R5T.Frisia.Suebia;


namespace R5T.Antium.Default
{
    public class RemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider : IAwsEc2ServerHostFriendlyNameProvider
    {
        private RemoteDeploymentSecretsSerialization RemoteDeploymentSecretsSerialization { get; }


        public RemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider(
            RemoteDeploymentSecretsSerialization remoteDeploymentSecretsSerialization)
        {
            this.RemoteDeploymentSecretsSerialization = remoteDeploymentSecretsSerialization;
        }


        public string GetHostFriendlyName()
        {
            var output = this.RemoteDeploymentSecretsSerialization.HostConnectionFriendlyName;
            return output;
        }
    }
}
