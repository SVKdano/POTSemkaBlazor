﻿using System;
namespace ShopSemka.Shared
{
	public class Product
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string ImageURL { get; set; } = string.Empty;
		public decimal Price { get; set; }

		public Product() { }
	}
}
