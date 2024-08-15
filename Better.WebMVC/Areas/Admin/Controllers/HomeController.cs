using Better.Service.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Better.WebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IRecipeService recipeService;

        public HomeController(IRecipeService recipeService) 
        {
            this.recipeService = recipeService;
        }
        public async Task<IActionResult> Index()
        {
            var recipes = await recipeService.GetAllRecipeAsync();
            return View(recipes);
        }
    }
}
