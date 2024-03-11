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
    public class HoldingsController : ControllerBase
    {
        private readonly IHoldingsManagerService _holdingsManagerService;
        public HoldingsController(IHoldingsManagerService holdingsManagerService)
        {
            _holdingsManagerService = holdingsManagerService;
        }

        [HttpPost(HoldingsControllerRoutes.Add)]
        public async Task<IActionResult> Add([FromBody] Holding holding)
        {
            if (holding == null)
                return BadRequest("Holding is null");

            await _holdingsManagerService.AddAsync(holding);
            return Ok("Holding added");
        }

        [HttpPost(HoldingsControllerRoutes.Update)]
        public async Task<IActionResult> Update([FromBody] Holding holding)
        {
            if (holding == null)
                return BadRequest("Holding is null");

            await _holdingsManagerService.UpdateAsync(holding);
            return Ok("Holding updated");
        }

        [HttpGet(HoldingsControllerRoutes.All)]
        public async Task<IActionResult> All()
        {
            var holdings = await _holdingsManagerService.GetAllAsync();
            return Ok(JsonConvert.SerializeObject(holdings));
        }

        [HttpGet(HoldingsControllerRoutes.AllByAccount)]
        public async Task<IActionResult> All([FromQuery] int acctNbr)
        {
            var holdings = await _holdingsManagerService.GetAllAsync();
            return Ok(JsonConvert.SerializeObject(holdings.Where(h => h.AcctNbr == acctNbr)));
        }

        [HttpDelete(HoldingsControllerRoutes.Delete)]
        public async Task<IActionResult> Delete([FromQuery] Guid id)
        {
            await _holdingsManagerService.DeleteAsync(id);
            return Ok("Holding deleted");
        }
    }
}
