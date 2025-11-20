using System.Dynamic;
using GappApi.Data;
using GappApi.Repos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GappApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdaptersController : ControllerBase
    {
        private readonly efRepo repo;

        public AdaptersController(AppDbContext _dbContext)
        {
            repo = new efRepo(_dbContext);
        }

        //Just the Ochestration table only
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await repo.getAdapters();

            var aliases = await repo.getAdapterAlias();

            dynamic response = new ExpandoObject();
            response.Adapters = list;
            response.Aliases = aliases;

            return new OkObjectResult(response);
        }

        //Full details including all the connected tables
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByID(int id)
        {
            var list = await repo.getAdapters(id);
            var aliases = await repo.getAdapterAlias(id);

            dynamic response = new ExpandoObject();
            response.Adapters = list;
            response.Aliases = aliases;

            return new OkObjectResult(response);
        }
    }
}
