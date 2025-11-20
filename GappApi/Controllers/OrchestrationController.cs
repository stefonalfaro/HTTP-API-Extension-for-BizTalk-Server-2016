using GappApi.Data;
using GappApi.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GappApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrchestrationController : ControllerBase
    {
        private readonly efRepo repo;

        public OrchestrationController(AppDbContext _dbContext)
        {
            repo = new efRepo(_dbContext);
        }

        //Just the Ochestration table only
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await repo.getFullOrchestration();
            return new OkObjectResult(list);
        }

        //Full details including all the connected tables
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var list = await repo.getFullOrchestration(id);
            return new OkObjectResult(list);
        }
    }
}
