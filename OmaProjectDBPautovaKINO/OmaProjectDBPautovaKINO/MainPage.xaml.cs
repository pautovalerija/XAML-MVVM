using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OmaProjectDBPautovaKINO
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();


        }
        private async void Admin_ClickedAsync(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new Admin());
        }
        private async void User_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new User());
        }
    }

}
