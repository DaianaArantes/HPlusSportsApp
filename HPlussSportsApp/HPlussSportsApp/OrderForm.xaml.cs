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
	public partial class OrderForm : TabbedPage
	{
		public OrderForm ()
		{
			InitializeComponent ();
		}

        public OrderForm(Order target)
        {
            InitializeComponent();
            BindingContext = target;
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            var order = BindingContext as Order;
            DisplayAlert("Order Placed", $"Order Placed for {order.Quantity} of {order.ProductName} ", "Ok");
        }
    }
}