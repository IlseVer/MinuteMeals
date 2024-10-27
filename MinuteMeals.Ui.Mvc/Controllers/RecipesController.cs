using Microsoft.AspNetCore.Mvc;
using MinuteMeals.Ui.Mvc.Core;


namespace MinuteMeals.Ui.Mvc.Controllers
{
	public class RecipesController : Controller
	{
		private readonly MinuteMealsDbContext _minuteMealsDbContext;

		public RecipesController(MinuteMealsDbContext minuteMealsDbContext)
		{
			_minuteMealsDbContext = minuteMealsDbContext;
		}

		public IActionResult Index()
		{
			var recipes = _minuteMealsDbContext.Recipes.ToList();
			return View(recipes);
		}

	}
}
