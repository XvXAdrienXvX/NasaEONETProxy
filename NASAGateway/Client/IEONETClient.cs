using NASAGateway.Models;

namespace NASAGateway.Client
{
    public interface IEONETClient
    {
        Task<EONETEventResponse> GetEventsByStatus(string status);
    }
}
