using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DameComidaMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTrackMeal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrackMeal());
        }

        private async void OnShowMeal_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShowMeal());
        }

        private async void OnManage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Manage());
        }
    }
}
