using Microsoft.EntityFrameworkCore;
using Shop.Interfaces;
using Shop.Models;

namespace Shop.Repository
{
	public class CarRepository : IAllCars
	{

		private readonly AppDBContent _appDBContent;
		public CarRepository(AppDBContent appDBContent)
		{
			_appDBContent = appDBContent;
		}

		public IEnumerable<Car> Cars => _appDBContent.Car.Include(c => c.Category);

		public IEnumerable<Car> getFavCars => _appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

		public Car getObjectCar(int carId) => _appDBContent.Car.FirstOrDefault(p => p.id == carId);
	}
}
