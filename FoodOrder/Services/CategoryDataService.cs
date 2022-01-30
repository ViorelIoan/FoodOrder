using Firebase.Database;
using FoodOrder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrder.Services
{
    public class CategoryDataService
    {
        FirebaseClient client;
        public CategoryDataService()
        {
            client = new FirebaseClient("https://foodorderapp-da474-default-rtdb.firebaseio.com/");
        }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = (await client.Child("Categories")
                .OnceAsync<Category>())
                .Select(client => new Category
                {
                    CategoryID = client.Object.CategoryID,
                    CategoryName = client.Object.CategoryName,
                    CategoryPoster = client.Object.CategoryPoster,
                    ImageUrl = client.Object.ImageUrl
                }).ToList();
            return categories;
        }
    }
}
