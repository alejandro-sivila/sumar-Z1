using Microsoft.AspNetCore.Mvc;

namespace sumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumaController : ControllerBase
    {
        [HttpGet]
        [Route("Add")]
        public int ADD(int a, int b)
        {
            return (a + b);
        }
        [HttpPost]
        [Route("Add2")]
        public int ADD2([FromHeader] int a, [FromHeader] int b)
        {
            return (a + b);
        }

        [HttpGet]
        [Route("Mult")]
        public int Mul(int a, int b)
        {
            return a * b;
        }

        [HttpPost]
        [Route("Mult")]
        public int Mul2([FromHeader] int a,[FromHeader] int b)
        {
            return a * b;
        }
    }
}
