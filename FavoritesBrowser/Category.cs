using System.Collections.Generic;

namespace FavoritesBrowser
{
	public class Category
	{
		public int CategoryID;
		public string CategoryName;

		public List<Product> CategoryProducts { private set; get; }

		public Category(int id, string name)
		{
			CategoryID = id;
			CategoryName = name;
		}
	}
}