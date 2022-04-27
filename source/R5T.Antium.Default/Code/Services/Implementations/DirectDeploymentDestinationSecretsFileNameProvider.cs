using System;

using R5T.T0064;


namespace R5T.Antium.Default
{
    /// <summary>
    /// Allows directly specifying the deployment secrets file name.
    /// </summary>
    [ServiceImplementationMarker]
    public class DirectDeploymentDestinationSecretsFileNameProvider : IDeploymentDestinationSecretsFileNameProvider, IServiceImplementation
    {
        private string DeploymentDestinationSecretsFileName { get; }


        public DirectDeploymentDestinationSecretsFileNameProvider(
            [NotServiceComponent] string deploymentDestinationSecretsFileName)
        {
            this.DeploymentDestinationSecretsFileName = deploymentDestinationSecretsFileName;
        }

        public string GetDeploymentDestinationSecretsFileName()
        {
            return this.DeploymentDestinationSecretsFileName;
        }
    }
}
