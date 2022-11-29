using la_mia_pizzeria_static.Models.Repositories;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        IPizzeriaRepository _pizzaRepository;

        public PizzaController(IPizzeriaRepository pizzaRepository) //diciamo al controller come si deve inizializzare
        {
            _pizzaRepository = pizzaRepository;
        }
        public ActionResult Get() //get va a recuperare le nostre pizze
        {
            List<Pizza> pizze = _pizzaRepository.All(); //lavora sui model, quindi sui dati 
            return Ok(pizze);   //restituisce json nella response body con codice 200
            
            
            //le funzioni di restituzione convertono automaticamente in Json
            //in questo modo abbiamo recuperato i dati

        }


        public ActionResult Search(string? name) 
        {
            List<Pizza> pizze = _pizzaRepository.SearchByTitle(name);
            return Ok(pizze);

        }
    }
}
