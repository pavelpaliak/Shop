﻿using Microsoft.EntityFrameworkCore;

namespace Shop.Models
{
	public class ShopCart
	{

		private readonly AppDBContent _appDBContent;
		public ShopCart(AppDBContent appDBContent)
		{
			_appDBContent = appDBContent;
		}

		public string ShopCartId { get; set; }
		public List<ShopCartItem> listShopItems { get; set; }

		public static ShopCart GetCart(IServiceProvider services)
		{
			ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
			var context = services.GetService<AppDBContent>();
			string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

			session.SetString("CartId", shopCartId);

			return new ShopCart(context)
			{
				ShopCartId = shopCartId
			};
		}
		public void AddToCart(Car car)
		{
			_appDBContent.ShopCartItem.Add(new ShopCartItem
			{
				ShopCartId = ShopCartId,
				car = car,
				price = car.price
			});

			_appDBContent.SaveChanges();
		}

		public List<ShopCartItem> getShopItems()
		{
			return _appDBContent.ShopCartItem.Where(c => c.ShopCartId == ShopCartId).Include(s => s.car).ToList();
		}
	}
}
