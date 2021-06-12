using ContosoRecipes.Data;
using ContosoRecipes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private readonly IRecipeDataStore _recipeData;
        public RecipesController(IRecipeDataStore recipeData)
        {
            _recipeData = recipeData;
        }

        [HttpGet]
        public async Task<ActionResult> GetRecipes([FromQuery] int count)
        {
            IEnumerable<Recipe> dishes = await _recipeData.GetRandomRecipes<Recipe>(count);    
            if (!dishes.Any())
                return NotFound();
            return Ok(dishes);
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
