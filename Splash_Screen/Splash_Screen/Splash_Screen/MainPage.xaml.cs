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

        protected  override void OnAppearing()
        {
            
            base.OnAppearing();

            

            Application.Current.MainPage = new Login();
            //await Navigation.PushModalAsync(new Login()); // PushModalAsync, sau in App.xaml.cs MainPage = new NavigationPage( new MainPage()); 




        }
    }
}
