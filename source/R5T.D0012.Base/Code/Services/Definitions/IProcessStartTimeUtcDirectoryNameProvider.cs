using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0012
{
    [ServiceDefinitionMarker]
    public interface IProcessStartTimeUtcDirectoryNameProvider : IServiceDefinition
    {
        Task<string> GetProcessStartTimeUtcDirectoryNameAsync();
    }
}
