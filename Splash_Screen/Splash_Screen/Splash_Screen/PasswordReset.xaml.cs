using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Splash_Screen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PasswordReset : ContentPage
	{
		public PasswordReset ()
		{
			InitializeComponent ();
		}

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void SendButton_Clicked(object sender, EventArgs e)
        {
            var email = EmailAddress.Text;
            var emailPattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";

            if (Regex.IsMatch(email, emailPattern))
            {
                EmailAddress.BackgroundColor = Color.Green;
            }
            else
                EmailAddress.BackgroundColor = Color.Red;
        }
    }
}