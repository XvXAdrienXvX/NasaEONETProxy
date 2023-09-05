using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NASAGateway.Client;

namespace NASAGateway.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProxyController : ControllerBase
    {
        private readonly IEONETClient _client;
        public ProxyController(IEONETClient client)
        {
            _client = client;
        }

        [HttpGet("events/{status}")]
        public async Task<IActionResult> GetEventsByStatus(string status)
        {
            try
            {
                var response = await _client.GetEventsByStatus(status);
                if (response == null)
                {
                    return NotFound();
                }

                return Ok(response);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
