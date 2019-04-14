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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();

		}

        public  void LoginButton_Clicked(object sender, EventArgs e)
        {

            var email = UserName.Text;
            var emailPattern = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
            var password = Password.Text;

            if (Regex.IsMatch(email, emailPattern))
            {
                UserName.BackgroundColor = Color.Green;
            } else
                UserName.BackgroundColor = Color.Red;


            if (password.Length >= 6)
            {
                Password.BackgroundColor = Color.Green;
            }
            else
                Password.BackgroundColor = Color.Red;

            if (UserName.BackgroundColor.Equals(Color.Green) && Password.BackgroundColor.Equals(Color.Green))
            {
                RotateImage();
            }
            else test.IsVisible = false;

            

            //test.Children.Add(new RotatingScreen());
            //test.IsVisible=false;
            //test.Children.Clear();
            //test.Children.Remove(new RotatingScreen());
            // await Navigation.PushModalAsync(new RotatingScreen());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            test.IsVisible = true;
            test.Opacity = 0.5;
            RotateImage();

            await Navigation.PushModalAsync(new PasswordReset());
        }

        private async void RotateImage()
        {
            test.IsVisible = true;
            test.Opacity = 0.5;

            for (int i = 0; i < 3; i++)
            {
                if (spinnerImage.Rotation >= 360f) spinnerImage.Rotation = 0;
                await spinnerImage.RotateTo(360, 1000, Easing.Linear);
            }
            test.IsVisible = false;
        }
    }
}