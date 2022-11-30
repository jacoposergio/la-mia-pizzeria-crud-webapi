using la_mia_pizzeria_static.Models.Repositories;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]",Order = 1)] //non obbligo piu a darmi una action ma solo a darmi un controller, c# pensa alla action
    [ApiController]
    public class PizzaController : ControllerBase
    {
        IPizzeriaRepository _pizzaRepository;

        public PizzaController(IPizzeriaRepository pizzaRepository) //diciamo al controller come si deve inizializzare
        {
            _pizzaRepository = pizzaRepository;
        }
        //public ActionResult Get() //get va a recuperare le nostre pizze
        //{
        //    List<Pizza> pizze = _pizzaRepository.All(); //lavora sui model, quindi sui dati 
        //    return Ok(pizze);   //restituisce json nella response body con codice 200


        //    //le funzioni di restituzione convertono automaticamente in Json
        //    //in questo modo abbiamo recuperato i dati

        //}


        //ora prende le funzione non tramite nome ma protocollo httpget, il nome nn serve più
        // api/post
        // api/pizza?name=[query]
        [HttpGet]
        public ActionResult Get(string? name) 
        {
            List<Pizza> pizze = _pizzaRepository.SearchByTitle(name);
            return Ok(pizze);

        }

        // api/pizza/[id]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Pizza pizza = _pizzaRepository.GetById(id);

            return Ok(pizza);
        }

        // /api/post
        [HttpPost]
        public IActionResult Update(Pizza pizza)
        {
            return Ok("ok");
        }
    }
}
