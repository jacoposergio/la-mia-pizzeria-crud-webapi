using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using lamiapizzeriastatic.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]", Order = 1)]
    [ApiController]
    public class MessageController : ControllerBase
    {
        PizzeriaDbContext db;
        public MessageController()
        {
            db = new PizzeriaDbContext();
        } 

        [HttpPost]
        //possiamo chiamarla come vogliamo, a fare il pattern matching sarà il post e il controller
        public IActionResult Create([FromBody] Message message)
        {
            //if ( !ModelState.IsValid)
            //{

            //    return Ok("modello nn valido");
            //}
            try
            {
                db.Messages.Add(message);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                return UnprocessableEntity(e.Message);
            }

            return Ok(message);
        }
    }
}
