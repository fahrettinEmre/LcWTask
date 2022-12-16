using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kuberntes.Poc.Controllers
{
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("ping")]
        public string ping()
        {
            return "pong";
        }

    }
}
