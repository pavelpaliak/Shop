﻿namespace Shop.Models
{
	public class Car
	{
		public int id { get; set; }

		public string name { get; set; }

		public string shortDesc { get; set; }

		public string longDesc { get; set; }

		public string img { get; set; }

		public int price { get; set; }

		public bool isFavourite { get; set; }

		public bool avalible { get; set; }
		public int categoryID { get; set; }

		public virtual Category Category { get; set; }
	}
}
