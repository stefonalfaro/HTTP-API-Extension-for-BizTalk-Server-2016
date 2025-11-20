using GappApi.Data;
using GappApi.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GappApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgreementsController : ControllerBase
    {
        private readonly efRepo repo;

        public AgreementsController(AppDbContext _dbContext)
        {
            repo = new efRepo(_dbContext);
        }

        //Just the Ochestration table only
        [HttpGet]
        public async Task<IActionResult> GetSummary()
        {
            var list = await repo.getFullAgreements();
            return new OkObjectResult(list);
        }

        //Full details including all the connected tables
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAll(int id)
        {
            var list = await repo.getFullAgreements(id);
            return new OkObjectResult(list);
        }
    }
}
