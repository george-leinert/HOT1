using Microsoft.AspNetCore.Mvc;
using DistanceConverter.Models;

namespace DistanceConverter.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.DistanceInInches = 0;
			ViewBag.DistanceInCentimeters = 0;
			return View();
		}

		[HttpPost]
		public IActionResult Index(DistanceConverterModel model)
		{
			if (ModelState.IsValid)
			{
				ViewBag.DistanceInInches = model.DistanceInInches;
				ViewBag.DistanceInCentimeters = model.ConvertToCentimeters();
			}
			else
			{
				ViewBag.DistanceInInches = 0;
				ViewBag.DistanceInCentimeters = 0;
			}
			return View(model);
		}
	}
}
