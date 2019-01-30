using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FirstApp.Models;

namespace FirstApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewDemo : ContentPage
	{
		public ListViewDemo ()
		{
			InitializeComponent ();

            
		}

        private void ButtonControl_Clicked(object sender, EventArgs e)
        {
            var message = "This is message";
            DependencyService.Get<Imessage>().showMessage(message);
        }
    }
}