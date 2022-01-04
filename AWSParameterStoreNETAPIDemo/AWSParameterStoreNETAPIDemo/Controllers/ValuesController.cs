using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AWSParameterStoreNETAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var connectionString = _configuration.GetValue<string>("connectionstring");
            var key1 = _configuration.GetValue<string>("key1");
            var key2 = _configuration.GetValue<string>("key2");
            return new string[] { connectionString, key1, key2 };
        }
    }
}
