using System;

using R5T.Frisia.Suebia;


namespace R5T.Antium.Default
{
    public class RemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider : IAwsEc2ServerHostFriendlyNameProvider
    {
        private IRemoteDeploymentSecretsSerializationProvider RemoteDeploymentSecretsSerializationProvider { get; }


        public RemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider(
            IRemoteDeploymentSecretsSerializationProvider remoteDeploymentSecretsSerializationProvider)
        {
            this.RemoteDeploymentSecretsSerializationProvider = remoteDeploymentSecretsSerializationProvider;
        }


        public string GetHostFriendlyName()
        {
            var remoteDeploymentSecretsSerialization = this.RemoteDeploymentSecretsSerializationProvider.GetRemoteDeploymentSecretsSerialization();

            var output = remoteDeploymentSecretsSerialization.HostConnectionFriendlyName;
            return output;
        }
    }
}
