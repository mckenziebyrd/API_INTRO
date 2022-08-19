using API_INTRO.Models;
using API_INTRO.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_INTRO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        //dependency injection - a way of handling resources (memory) in your application
        //private PizzaRepository _pizzaRepo = new PizzaRepository();
        private IPizzaRepostitory _pizzaRepo;


        // GET: api/<PizzaController>
        [HttpGet]
        public List<Pizza> GetAllPizzas()
        {
            return _pizzaRepo.GetAll();        
           
        }

        // GET api/<PizzaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _pizzaRepo.GetById;
        }

        // POST api/<PizzaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PizzaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PizzaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
