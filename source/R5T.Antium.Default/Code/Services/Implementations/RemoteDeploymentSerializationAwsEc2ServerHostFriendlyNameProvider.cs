using System;

using R5T.Frisia.Suebia;

using R5T.T0064;


namespace R5T.Antium.Default
{
    [ServiceImplementationMarker]
    public class RemoteDeploymentSerializationAwsEc2ServerHostFriendlyNameProvider : IAwsEc2ServerHostFriendlyNameProvider, IServiceImplementation
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
