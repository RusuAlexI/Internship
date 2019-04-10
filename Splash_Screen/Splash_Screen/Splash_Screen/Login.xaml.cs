using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Splash_Screen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();

		}

        public  void LoginButton_Clicked(object sender, EventArgs e)
        {
            test.IsVisible = true;
            test.Opacity = 0.5;
            test.Children.Add(new RotatingScreen());

            //test.IsVisible=false;
            //test.Children.Clear();
            //test.Children.Remove(new RotatingScreen());
            


            // await Navigation.PushModalAsync(new RotatingScreen());
        }
    }
}