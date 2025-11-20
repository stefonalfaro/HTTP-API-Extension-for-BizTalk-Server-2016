using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace GappApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminToolsController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AdminToolsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("TestSQLServer")]
        public async Task<IActionResult> TestSQLServer()
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    var serverVersion = connection.ServerVersion;
                    var database = connection.Database;
                    var dataSource = connection.DataSource;

                    return Ok(new
                    {
                        Success = true,
                        Message = "Connection successful!",
                        ServerVersion = serverVersion,
                        Database = database,
                        DataSource = dataSource,
                        State = connection.State.ToString()
                    });
                }
            }
            catch (SqlException ex)
            {
                return StatusCode(500, new
                {
                    Success = false,
                    Message = "SQL Server connection failed",
                    Error = ex.Message,
                    ErrorNumber = ex.Number,
                    StackTrace = ex.StackTrace
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Success = false,
                    Message = "Connection failed",
                    Error = ex.Message,
                    StackTrace = ex.StackTrace
                });
            }
        }
    }
}
