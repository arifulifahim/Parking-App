using Microsoft.Maui.Controls;

namespace ParkingApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnRegisterClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterTypePage());
        }

        void OnLoginClicked(object sender, EventArgs e)
        {
            // If this method should perform async operations, add them here, otherwise, consider making this method synchronous
            Navigation.PushAsync(new LoginPage());  // Assuming you meant to navigate somewhere else here
        }
    }
}
