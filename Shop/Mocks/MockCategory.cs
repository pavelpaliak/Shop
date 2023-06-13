using Shop.Interfaces;
using Shop.Models;

namespace Shop.Mocks
{
	public class MockCategory : ICarsCategory
	{
		public IEnumerable<Category> AllCategories
		{
			get
			{
				return new List<Category>
				{
					new Category { categoryName = "Electrosamochody", desc="Nowoczesny rodzaj transportu"},
					new Category { categoryName = "Samochody klasyczne", desc="Samochody z silnikiem spalinowym"}
				};
			}
		}
	}
}