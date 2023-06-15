using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop
{
	public class AppDBContent : DbContext
	{
		public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
		{

		}
		public DbSet<Car> Car { get; set; }
		public DbSet<Category> Category { get; set; }
		public DbSet<ShopCartItem> ShopCartItem { get; set; }
	}
}
