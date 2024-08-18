using Microsoft.AspNetCore.Mvc;

namespace Better.WebMVC.Recipes
{
    public class RecipeHomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
