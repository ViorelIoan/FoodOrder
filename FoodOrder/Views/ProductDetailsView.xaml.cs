using FoodOrder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodOrder.Views
{
    public partial class ProductDetailsView : ContentPage
    {
        public ProductDetailsView(FoodItem foodItem)
        {
            InitializeComponent();
        }
    }
}