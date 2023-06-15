using Shop.Models;

namespace Shop.Interfaces
{
	public interface IAllCars
	{
		IEnumerable<Car> Cars { get; }
		IEnumerable<Car> getFavCars { get; }
		Car getObjectCar(int carId);
	}
}
