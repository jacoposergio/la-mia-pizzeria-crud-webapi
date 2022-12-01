using la_mia_pizzeria_static.Models.Repositories;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using la_mia_pizzeria_static.Data;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]", Order = 1)] //non obbligo piu a darmi una action ma solo a darmi un controller, c# pensa alla action
    [ApiController]
    public class PizzaController : ControllerBase
    {
        IPizzeriaRepository _pizzaRepository;

        public PizzaController(IPizzeriaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }
        

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

    }
}