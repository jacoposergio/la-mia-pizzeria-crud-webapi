using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {

        [HttpPost]
        //possiamo chiamarla come vogliamo, a fare il pattern matching sarà il post e il controller
        public IActionResult Create(MessageController message)
        {
            return Ok("da implementare");
        }
    }
}
