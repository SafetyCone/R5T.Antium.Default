using System;

using R5T.T0064;


namespace R5T.Antium.Default
{
    [ServiceDefinitionMarker]
    public interface IDeploymentDestinationSecretsFileNameProvider : IServiceDefinition
    {
        string GetDeploymentDestinationSecretsFileName();
    }
}
