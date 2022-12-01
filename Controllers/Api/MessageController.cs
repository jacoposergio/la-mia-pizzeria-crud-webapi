using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using la_mia_pizzeria_static.Models.Repositories;
using lamiapizzeriastatic.Migrations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]", Order = 1)]
    [ApiController]
    public class MessageController : ControllerBase
    {
        public PizzeriaDbContext db;
        IPizzeriaRepository pizzaRepository;
        //public MessageController()
        //{
        //    db = new PizzeriaDbContext();
        //}

        public MessageController(IPizzeriaRepository _pizzaRepository, PizzeriaDbContext _db)
        {
            pizzaRepository = _pizzaRepository;
            db = _db;
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
