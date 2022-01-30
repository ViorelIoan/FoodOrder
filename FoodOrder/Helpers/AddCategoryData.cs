using System;
using System.Collections.Generic;
using FoodOrder.Model;
using Firebase.Database;
using System.Threading.Tasks;
using Firebase.Database.Query;
using Xamarin.Forms;

namespace FoodOrder.Helpers
{
    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }
        FirebaseClient client;
        public AddCategoryData()
        {
            client = new FirebaseClient("https://foodorderapp-da474-default-rtdb.firebaseio.com/");
            Categories = new List<Category>()
            {
                new Category()
                {
                    CategoryID = 1,
                    CategoryName = "Burgers",
                    CategoryPoster = "MainBurger",
                    ImageUrl = "Burger.png"
                },
                new Category()
                {
                    CategoryID = 2,
                    CategoryName = "Pizza",
                    CategoryPoster = "MainPizza",
                    ImageUrl = "Pizza.png"
                },
                new Category()
                {
                    CategoryID = 3,
                    CategoryName = "Desserts",
                    CategoryPoster = "MainDessert",
                    ImageUrl = "Dessert.png"
                },
                new Category()
                {
                    CategoryID = 1,
                    CategoryName = "Veg Burgers",
                    CategoryPoster = "MainBurger",
                    ImageUrl = "Burger.png"
                },
                new Category()
                {
                    CategoryID = 2,
                    CategoryName = "Veg Pizza",
                    CategoryPoster = "MainPizza",
                    ImageUrl = "Pizza.png"
                },
                new Category()
                {
                    CategoryID = 3,
                    CategoryName = "Cakes",
                    CategoryPoster = "MainDessert",
                    ImageUrl = "Dessert.png"
                }
            };
        }

        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach (var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        CategoryPoster = category.CategoryPoster,
                        ImageUrl = category.ImageUrl,
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
            }
        }

    }
}
