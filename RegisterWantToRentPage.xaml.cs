using Microsoft.Maui.Controls;

namespace ParkingApp
{
    public partial class RegisterWantToRentPage : ContentPage
    {
        public RegisterWantToRentPage()
        {
            InitializeComponent();
        }

        void OnTermsCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            submitButton.IsVisible = e.Value;  // Ensure the submit button visibility changes based on the checkbox
        }

        async void OnSubmitClicked(object sender, EventArgs e)
        {
            // Optionally simulate some asynchronous operation
            await Task.Delay(100);  // Placeholder for async work
            await Navigation.PushAsync(new SuccessPage());
        }
    }
}
