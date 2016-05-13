using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using FavoritesBrowser.Views;
using Xamarin.Forms.Xaml;

namespace FavoritesBrowser
{
    
	public class App : PrismApplication
	{
        public List<Product> prods;
        public List<Category> categories;

        protected override void OnInitialized()
        { 
             NavigationService.Navigate("MainPage"); 
         } 
 
 
         protected override void RegisterTypes()
         { 
             Container.RegisterTypeForNavigation<MainPage>(); 
         }


        public App()
		{
			prods = new List<Product>
			{
				new Product(1, "A Nice Pen", false),
				new Product(2, "A Typical Mug", true),
				new Product(3, "Promotional Widget", false)
			};

			categories = new List<Category>
			{
				new Category(101, "Writing"),
				new Category(102, "Drinkware")
			};

            #region wtf
            /*
			// The root page of your application
			var content = new ContentPage
			{
				Title = "FavoritesBrowser",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new ListView{
							ItemsSource = categories,

							ItemTemplate = new DataTemplate(() =>
							{
		                        // Create views with bindings for displaying each property.
		                        Label nameLabel = new Label();
								znameLabel.SetBinding(Label.TextProperty, "CategoryName");
								return new ViewCell
								{
									View = new StackLayout
									{
										Padding = new Thickness(0, 5),
										Orientation = StackOrientation.Horizontal,
										Children =
										{
											new StackLayout
											{
												VerticalOptions = LayoutOptions.Center,
												Spacing = 0,
												Children =
												{
													nameLabel
												}
											}
										}
									}
								}; // ViewCell
							}); // DataTemplate

						} // ListView
                    } // Children
				}; // StackLayout
		}; // ContentPage

		MainPage = new NavigationPage(content);*/
            #endregion
        }
	}
}

