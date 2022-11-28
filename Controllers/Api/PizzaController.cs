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

        public PizzaController(IPizzeriaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }
        public ActionResult Get()
        {
            List<Pizza> pizze = _pizzaRepository.All(); //lavora sui model, quindi sui dati 
            return Ok(pizze);   //le funzioni di restituzione convertono automaticamente in Json
            //in questo modo abbiamo recuperato i dati

        }
    }
}
