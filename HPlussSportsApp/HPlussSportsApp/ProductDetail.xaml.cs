using HPlusSports.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HPlussSportsApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductDetail : ContentPage
	{
		public ProductDetail ()
		{
			InitializeComponent ();
		}
        public ProductDetail(Product target)
        {
            InitializeComponent();
            BindingContext = target;
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            var target = BindingContext as Product;

            Navigation.PushAsync(new OrderForm(new Order { ProductName = target.Name, Quantity = 1 }));
        }
    }
}