using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI_DotNet8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
       
        public TestController() 
        {
           
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetAllHeroes()
        {
            int wojtek = 1;
            //fsdfsdfsdfds
            // cokolwiek
            //Test
            //test2
            return Ok("Working");
        }
        
    }
}
