using System.Collections.Generic;

namespace FavoritesBrowser
{
	public class Product
	{
		public string ProductName { private set; get; }

		public int ProductID { private set; get; }

		public List<Category> RelatedCategories { get; set; }

		public bool IsFavorite { private set; get; }

		public Product(int productID, string productName, bool isFavorite)
		{
			this.ProductName = productName;
			this.ProductID = productID;
			this.IsFavorite = isFavorite;
		}
	}
}