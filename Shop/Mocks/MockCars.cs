using Shop.Interfaces;
using Shop.Models;

namespace Shop.Mocks
{
	public class MockCars : IAllCars
	{
		private readonly ICarsCategory _categoryCars = new MockCategory();
		public IEnumerable<Car> Cars
		{
			get
			{
				return new List<Car>
				{
					new Car
					{ name = "Tesla Model S",
					  shortDesc = "Szybkie auto",
					  longDesc = "Piękny, szybki i bardzo ciche auto",
					  img = "/img/Tesla_Model_S.jpg",
					  price = 230000,
					  isFavourite = true,
					  avalible = true,
					  Category = _categoryCars.AllCategories.First()
					},
					new Car
					{ name = "Ford Fiesta",
					  shortDesc = "Ciche i spokojne",
					  longDesc = "Wygodny samochód do życia w mieście",
					  img = "/img/Ford_Fiesta.jpg",
					  price = 52000,
					  isFavourite = true,
					  avalible = true,
					  Category = _categoryCars.AllCategories.Last()
					},
					new Car
					{ name = "BMW M3",
					  shortDesc = "Zgrabny i stylowy",
					  longDesc = "Wygodny samochód do życia w mieście",
					  img = "/img/BMW_M3.jpg",
					  price = 240000,
					  isFavourite = true,
					  avalible = true,
					  Category = _categoryCars.AllCategories.Last()
					},
					new Car
					{ name = "Mercedes C class",
					  shortDesc = "Przytulny i duży",
					  longDesc = "Wygodny samochód do życia w mieście",
					  img = "/img/Mercedes_C_Class.jpg",
					  price = 180000,
					  isFavourite = false,
					  avalible = false,
					  Category = _categoryCars.AllCategories.Last()
					},
					new Car
					{ name = "Nissan Leaf",
					  shortDesc = "Сichy i ekonomiczny",
					  longDesc = "Wygodny samochód do życia w mieście",
					  img = "/img/Nissan_Leaf.jpg",
					  price = 62000,
					  isFavourite = true,
					  avalible = true,
					  Category = _categoryCars.AllCategories.First()
					}
				};
			}
		}
		public IEnumerable<Car> getFavCars { get; set; }

		public Car getObjectCar(int carId)
		{
			throw new NotImplementedException();
		}
	}
}
