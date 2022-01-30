using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodOrder.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _Username;
        private string Username;

        private string _Password;
        private string Passwoed;

        private bool _IsBusy;
        private bool IsBusy;

        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync());
            RegisterCommand = new Command(async () => await RegisterCommandAsync());
        }

        private Task RegisterCommandAsync()
        {
            throw new NotImplementedException();
        }

        private Task LoginCommandAsync()
        {
            throw new NotImplementedException();
        }
    }
}
