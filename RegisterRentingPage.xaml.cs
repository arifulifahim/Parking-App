using Microsoft.Maui.Controls;

namespace ParkingApp
{
    public partial class RegisterRentingPage : ContentPage
    {
        public RegisterRentingPage()
        {
            InitializeComponent();
        }

        void OnSameAddressToggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                mailingAddress.Text = parkingAddress.Text;
            }
            else
            {
                mailingAddress.Text = string.Empty;
            }
        }

        void OnTermsCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            submitButton.IsVisible = e.Value;  // Correct property for CheckBox in .NET MAUI
        }

        async void OnSubmitClicked(object sender, EventArgs e)
        {
            // Assuming some asynchronous operation here
            await Task.Delay(100);  // Just a placeholder for async work
            await Navigation.PushAsync(new SuccessPage());
        }

        void OnUploadClicked(object sender, EventArgs e)
        {
            // Implementation for uploading an image
        }
    }
}
