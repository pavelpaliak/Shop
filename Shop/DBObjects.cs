using Shop.Models;

namespace Shop
{
	public class DBObjects
	{
		public static void Initial(AppDBContent content)
		{
						
			if (!content.Category.Any())
				content.Category.AddRange(Categories.Select(c => c.Value));

			if (!content.Category.Any())
			{
				content.AddRange
					(
					new Car
					{
						name = "Tesla Model S",
						shortDesc = "Szybkie auto",
						longDesc = "Piękny, szybki i bardzo ciche auto",
						img = "/img/Tesla_Model_S.jpg",
						price = 230000,
						isFavourite = true,
						avalible = true,
						Category = Categories["Electrosamochody"]
					},
					new Car
					{
						name = "Ford Fiesta",
						shortDesc = "Ciche i spokojne",
						longDesc = "Wygodny samochód do życia w mieście",
						img = "/img/Ford_Fiesta.jpg",
						price = 52000,
						isFavourite = true,
						avalible = true,
						Category = Categories["Samochody klasyczne"]
					},
					new Car
					{
						name = "BMW M3",
						shortDesc = "Zgrabny i stylowy",
						longDesc = "Wygodny samochód do życia w mieście",
						img = "/img/BMW_M3.jpg",
						price = 240000,
						isFavourite = true,
						avalible = true,
						Category = Categories["Samochody klasyczne"]
					},
					new Car
					{
						name = "Mercedes C class",
						shortDesc = "Przytulny i duży",
						longDesc = "Wygodny samochód do życia w mieście",
						img = "/img/Mercedes_C_Class.jpg",
						price = 180000,
						isFavourite = false,
						avalible = false,
						Category = Categories["Samochody klasyczne"]
					},
					new Car
					{
						name = "Nissan Leaf",
						shortDesc = "Сichy i ekonomiczny",
						longDesc = "Wygodny samochód do życia w mieście",
						img = "/img/Nissan_Leaf.jpg",
						price = 62000,
						isFavourite = true,
						avalible = true,
						Category = Categories["Electrosamochody"]
					}
					);
			}

			content.SaveChanges();

		}

		private static Dictionary<string, Category> category;
		public static Dictionary<string, Category> Categories 
		{
			get
			{
				if(category == null)
				{
					var list = new Category[]
					{
						new Category { categoryName = "Electrosamochody", desc="Nowoczesny rodzaj transportu"},
						new Category { categoryName = "Samochody klasyczne", desc="Samochody z silnikiem spalinowym"}
					};
					category = new Dictionary<string, Category>();
					foreach (Category el in list)
						category.Add(el.categoryName, el);
				}
				return category;
			}
		}
	}
}
