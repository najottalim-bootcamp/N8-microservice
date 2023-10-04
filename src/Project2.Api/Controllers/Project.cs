using Microsoft.AspNetCore.Mvc;

namespace Project2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Project : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get() 
            => new string[] { "value1", "value2" };

        [HttpGet("{id}")]
        public  string Get(int id)
            => $"Bu siz kiritgan raqam + {id}";

        [HttpPost]
        public void Post([FromBody] string value)
            => Ok(true);

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
            => Ok(true);

        [HttpDelete("{id}")]
        public void Delete(int id)
            => Ok(true);
    }
}
