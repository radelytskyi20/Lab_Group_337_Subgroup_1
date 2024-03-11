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
    public class MastersController : ControllerBase
    {
        private readonly IMastersManagerService _mastersManagerService;
        public MastersController(IMastersManagerService mastersManagerService)
        {
            _mastersManagerService = mastersManagerService;
        }

        [HttpPost(MastersControllerRoutes.Add)]
        public async Task<IActionResult> Add([FromBody] Master master)
        {
            if (master == null)
                return BadRequest("Master is null");

            await _mastersManagerService.AddAsync(master);
            return Ok("Master added");
        }

        [HttpPost(MastersControllerRoutes.Update)]
        public async Task<IActionResult> Update([FromBody] Master master)
        {
            if (master == null)
                return BadRequest("Master is null");

            await _mastersManagerService.UpdateAsync(master);
            return Ok("Master updated");
        }

        [HttpGet(MastersControllerRoutes.All)]
        public async Task<IActionResult> All()
        {
            var masters = await _mastersManagerService.GetAllAsync();
            return Ok(JsonConvert.SerializeObject(masters));
        }

        [HttpDelete(MastersControllerRoutes.Delete)]
        public async Task<IActionResult> Delete([FromQuery] string symbol)
        {
            await _mastersManagerService.DeleteAsync(symbol);
            return Ok("Master deleted");
        }
    }
}
