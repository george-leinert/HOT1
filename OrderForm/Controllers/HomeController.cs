using Microsoft.AspNetCore.Mvc;
using OrderForm.Models;

namespace OrderForm.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.Tax = 0;
			ViewBag.Total = 0;
			ViewBag.SubTotal = 0;
			ViewBag.PricePerShirt = 0;
			ViewBag.OrderQuantity = 0;
			return View();
		}

		[HttpPost]
		public IActionResult Index(OrderFormModel model)
		{
			if (ModelState.IsValid)
			{
				ViewBag.Total = model.CalculatePrice();
				ViewBag.Tax = model.Tax;
				ViewBag.Subtotal = model.Subtotal;
				ViewBag.PricePerShirt = model.PricePerShirt;
				ViewBag.OrderQuantity = model.OrderQuantity;
				ViewBag.DiscountMessage = model.DiscountMessage;
			}
			else
			{
				ViewBag.Tax = 0;
				ViewBag.Total = 0;
				ViewBag.SubTotal = 0;
				ViewBag.PricePerShirt = 0;
				ViewBag.OrderQuantity = 0;
				ViewBag.DiscountMessage = model.DiscountMessage;
			}
			return View(model);
		}
	}
}

