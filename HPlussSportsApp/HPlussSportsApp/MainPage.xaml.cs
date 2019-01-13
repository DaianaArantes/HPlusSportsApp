using HPlusSports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HPlussSportsApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
          //  Navigation.PushAsync(new ProductDetail());
        //}

        private void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Product target = e.Item as Product;
            Navigation.PushAsync(new ProductDetail(target));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var products = await ProductService.GetProductsAsync();
            BindingContext = products;
        }
    }
}
