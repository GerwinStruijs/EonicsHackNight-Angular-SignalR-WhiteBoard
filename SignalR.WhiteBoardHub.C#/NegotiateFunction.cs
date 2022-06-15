using Microsoft.Azure.WebJobs;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.SignalRService;

namespace WhiteBoardFunctions
{

    public static class NegotiateFunction
    {
        // BASIC NEGOTIATE FUNCTION
        [FunctionName("negotiate")]
        public static SignalRConnectionInfo Negotiate(
            [HttpTrigger(AuthorizationLevel.Anonymous)] HttpRequest req,
            [SignalRConnectionInfo(HubName = "draw")] SignalRConnectionInfo connectionInfo)
        {
            return connectionInfo;
        }


    }
}
