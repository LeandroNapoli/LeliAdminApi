using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace LeliAdminApi.Controllers
{
    [ApiController]
    [Route(template:"v1")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route(template:"get")]
        public string GetExample()
        {
            return "teste ok";
        }
    }
}
