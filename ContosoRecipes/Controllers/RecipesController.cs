using ContosoRecipes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRecipes([FromQuery] int count)
        {
            Recipe[] dishes = {
                new() { Title = "Oxtail" },
                new() { Title = "Curry Chicken" },
                new() { Title = "Dumplings" }
            };
            
            return Ok(dishes.Take(count));
        }
        [HttpPost]
        public ActionResult CreateNewRecipes([FromBody] Recipe recipe)
        {
            bool validRecipes = false;
            if (validRecipes)
                return BadRequest();
            return Created("",recipe);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteRecipes(int id)
        {
            bool badThingHappened = false;
            if (badThingHappened)
                return BadRequest();
            return NoContent();
        }
        [HttpPatch]
        public ActionResult UpdateRecipes()
        {
            bool recipeExist = false;
            if (!recipeExist)
                return BadRequest();
            return NoContent();
        }
    }
}
