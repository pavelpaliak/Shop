using Microsoft.AspNetCore.Mvc;
using Shop.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
	public class CarsController : Controller
	{
		private readonly IAllCars _allCars;
		private readonly ICarsCategory _allCategories;

		public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
		{
			_allCars = iAllCars;
			_allCategories = iCarsCat;
		}

		public ViewResult List()
		{
			CarsListViewModel obj = new CarsListViewModel();
			ViewBag.Title = "Strona z autami";
			obj.allCars = _allCars.Cars;
			obj.currCategory = "Auta";

			return View(obj);
		}
	}
}
