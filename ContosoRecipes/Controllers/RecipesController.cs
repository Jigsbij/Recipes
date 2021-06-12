using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ContosoRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetRecipes()
        {
            string[] dishes = { "Oxtail", "Curry Chicken", "Dumplings" };
            if (dishes.Any())
            {
                return NotFound();
            }
            return Ok(dishes);
        }
        [HttpPost]
        public ActionResult CreateNewRecipes()
        {

        }
        [HttpDelete]
        public ActionResult DeleteRecipes()
        {

        }
    }
}
