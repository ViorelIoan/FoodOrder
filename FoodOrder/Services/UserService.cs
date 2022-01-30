using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
using System.Threading.Tasks;
using System.Linq;
using FoodOrder.Model;
using Firebase.Database.Query;

namespace FoodOrder.Services
{
    public class UserService
    {
        FirebaseClient client;

        public UserService()
        {
            client = new FirebaseClient("https://foodorderapp-da474-default-rtdb.firebaseio.com/");
        }

        public async Task<bool> IsUserExists(string uname) //Check if the user exists
        {
            var user = (await client.Child("Users")  //Users will act as table
                .OnceAsync<User>()).Where(u => u.Object.Username == uname).FirstOrDefault();

            return (user != null);
        }

        public async Task<bool> RegisterUser(string uname, string passwd)
        {
            if (await IsUserExists(uname) == false)
            {
                await client.Child("Users")
                .PostAsync(new User()
                {
                    Username = uname,
                    Password = passwd
                });
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> LoginUser(string uname, string passwd) //Check if the user/pass combination exists
        {
            var user = (await client.Child("Users")  //Users will act as table
                .OnceAsync<User>()).Where(u => u.Object.Username == uname).Where(u => u.Object.Password == passwd).FirstOrDefault();

            return (user != null);
        }


    }
}
