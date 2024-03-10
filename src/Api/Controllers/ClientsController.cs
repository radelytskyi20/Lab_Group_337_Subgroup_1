using Library.Constants;
using Library.Models;
using Library.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class ClientsController : ControllerBase
    {
        private readonly IClientsManagerService _clientsManagerService;

        public ClientsController(IClientsManagerService clientsManagerService)
        {
            _clientsManagerService = clientsManagerService;
        }

        [HttpPost(ClientsControllerRoutes.Add)]
        public async Task<IActionResult> Add([FromBody] Client client)
        {
            if (client == null)
                return BadRequest("Client is null");

            await _clientsManagerService.AddAsync(client);
            return Ok("Client added");
        }

        [HttpPost(ClientsControllerRoutes.Update)]
        public async Task<IActionResult> Update([FromBody] Client client)
        {
            if (client == null)
                return BadRequest("Client is null");

            await _clientsManagerService.UpdateAsync(client);
            return Ok("Client updated");
        }

        [HttpGet(ClientsControllerRoutes.All)]
        public async Task<IActionResult> GetAll()
        {
            var clients = await _clientsManagerService.GetAllAsync();
            return Ok(JsonConvert.SerializeObject(clients));
        }

        [HttpPost(ClientsControllerRoutes.Delete)]
        public async Task<IActionResult> Delete([FromQuery] int acctNbr)
        {
            await _clientsManagerService.DeleteAsync(acctNbr);
            return Ok("Client deleted");
        }
    }
}
