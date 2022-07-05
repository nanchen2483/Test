using Microsoft.AspNetCore.Mvc;

namespace Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        public TestController()
        {
        }

        [HttpGet(Name = "Test")]
        public ActionResult Test()
        {
            return Ok();
        }
    }
}
