using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MinuteMeals.Ui.Mvc.Core;
using MinuteMeals.Ui.Mvc.Models;

namespace MinuteMeals.Ui.Mvc.Controllers
{
	public class HomeController : Controller
	{
		private readonly MinuteMealsDbContext _minuteMealsDbContext;

		public HomeController(MinuteMealsDbContext minuteMealsDbContext)
		{
			_minuteMealsDbContext = minuteMealsDbContext;
		}

		public IActionResult Index()
		{
			var recipes = _minuteMealsDbContext.Recipes.ToList();
			return View(recipes);
		}

		public IActionResult RecipeDetailPartial(int id)
		{
			var recipe = _minuteMealsDbContext.Recipes.FirstOrDefault(r => r.Id == id);

			return PartialView(recipe);
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
