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
	public partial class Register : ContentPage
	{
		public Register ()
		{
			InitializeComponent ();
		}

        private void ShowPass1(object sender, EventArgs e)
        {
            Password.IsPassword = Password.IsPassword ? false : true;
        }

        private void ShowPass2(object sender, EventArgs e)
        {
            RepeatPassword.IsPassword = RepeatPassword.IsPassword ? false : true;
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}