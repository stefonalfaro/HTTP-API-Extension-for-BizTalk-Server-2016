using GappApi.Data;
using GappApi.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GappApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradingPartnersController : ControllerBase
    {
        private readonly efRepo repo;

        public TradingPartnersController(AppDbContext _dbContext)
        {
            repo = new efRepo(_dbContext);
        }

        //Just the Ochestration table only
        [HttpGet]
        public async Task<IActionResult> GetSummGetAllry()
        {
            var list = await repo.getFullTradingPartners();
            return new OkObjectResult(list);
        }

        //Full details including all the connected tables
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var list = await repo.getFullTradingPartners(id);
            return new OkObjectResult(list);
        }
    }
}
