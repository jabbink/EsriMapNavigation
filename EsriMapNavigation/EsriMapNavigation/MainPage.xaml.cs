using System;
using Xamarin.Forms;

namespace EsriMapNavigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void OnEsriButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPageEsri());
        }
        private async void OnFormsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPageForms());
        }
    }
}
