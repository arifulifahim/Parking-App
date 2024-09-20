using Microsoft.Maui.Controls;

namespace ParkingApp
{
    public partial class RegisterTypePage : ContentPage
    {
        public RegisterTypePage()
        {
            InitializeComponent();
        }

        async void OnRentingClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterRentingPage());
        }

        async void OnWantToRentClicked(object sender, EventArgs e)
        {
            // Make sure the RegisterWantToRentPage exists and is referenced correctly
            await Navigation.PushAsync(new RegisterWantToRentPage());
        }
    }
}
