using System;


namespace R5T.Antium.Default
{
    /// <summary>
    /// Allows directly specifying the deployment secrets file name.
    /// </summary>
    public class DirectDeploymentDestinationSecretsFileNameProvider : IDeploymentDestinationSecretsFileNameProvider
    {
        private string DeploymentDestinationSecretsFileName { get; }


        public DirectDeploymentDestinationSecretsFileNameProvider(string deploymentDestinationSecretsFileName)
        {
            this.DeploymentDestinationSecretsFileName = deploymentDestinationSecretsFileName;
        }

        public string GetDeploymentDestinationSecretsFileName()
        {
            return this.DeploymentDestinationSecretsFileName;
        }
    }
}
