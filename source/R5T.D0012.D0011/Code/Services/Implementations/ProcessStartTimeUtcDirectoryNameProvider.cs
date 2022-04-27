using System;
using System.Threading.Tasks;

using R5T.D0008;
using R5T.D0011;using R5T.T0064;


namespace R5T.D0012.D0011
{[ServiceImplementationMarker]
    public class ProcessStartTimeUtcDirectoryNameProvider : IProcessStartTimeUtcDirectoryNameProvider,IServiceImplementation
    {
        private IProcessStartTimeUtcProvider ProcessStartTimeUtcProvider { get; }
        private ITimestampUtcDirectoryNameProvider TimestampUtcDirectoryNameProvider { get; }


        public ProcessStartTimeUtcDirectoryNameProvider(
            IProcessStartTimeUtcProvider processStartTimeUtcProvider,
            ITimestampUtcDirectoryNameProvider timestampUtcDirectoryNameProvider)
        {
            this.ProcessStartTimeUtcProvider = processStartTimeUtcProvider;
            this.TimestampUtcDirectoryNameProvider = timestampUtcDirectoryNameProvider;
        }

        public async Task<string> GetProcessStartTimeUtcDirectoryNameAsync()
        {
            var processStartTimeUtc = await this.ProcessStartTimeUtcProvider.GetProcessStartTimeUtcAsync();

            var processStartTimeDirectorName = await this.TimestampUtcDirectoryNameProvider.GetTimestampUtcDirectoryNameAsync(processStartTimeUtc);
            return processStartTimeDirectorName;
        }
    }
}
