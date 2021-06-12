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
            string[] dishes = { "Oxtail", "Curry Chicken", "Dumplings" };
            if (! dishes.Any())
            {
                return NotFound();
            }
            return Ok(dishes);
        }
        [HttpPost]
        public ActionResult CreateNewRecipes()
        {
            bool validRecipes = false;
            if (!validRecipes)
                return BadRequest();
            return NoContent();
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
