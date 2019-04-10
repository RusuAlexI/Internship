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
    public partial class RotatingScreen : ContentView
    {
        public RotatingScreen()
        {
            InitializeComponent();
            RotateImage();
        }

        private async void RotateImage()
        {
            for(int i = 0; i < 3; i++)
            {
                if (spinningImage.Rotation >= 360f) spinningImage.Rotation = 0;
                await spinningImage.RotateTo(360, 1000, Easing.Linear);
            }

            await Navigation.PushModalAsync(new Login());
        }

    }
}