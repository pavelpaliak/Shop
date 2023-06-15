using Shop.Interfaces;
using Shop.Models;

namespace Shop.Repository
{
	public class CategoryRepository : ICarsCategory
	{

		private readonly AppDBContent _appDBContent; 
		public CategoryRepository(AppDBContent appDBContent)
		{
			_appDBContent = appDBContent;
		}

		public IEnumerable<Category> AllCategories => _appDBContent.Category;
	}
}
