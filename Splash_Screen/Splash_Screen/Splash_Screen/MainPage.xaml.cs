using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Splash_Screen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            
            base.OnAppearing();
            await Task.Delay(3000);
            await Navigation.PushModalAsync(new Login()); // PushModalAsync, sau in App.xaml.cs MainPage = new NavigationPage( new MainPage()); 




        }
    }
}
