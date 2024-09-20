using Microsoft.Maui.Controls;

namespace ParkingApp
{
    public partial class SuccessPage : ContentPage
    {
        public SuccessPage()
        {
            InitializeComponent();
        }

        async void OnOkClicked(object sender, EventArgs e)
        {
            // This line pops all pages on the navigation stack, except the root page.
            await Navigation.PopToRootAsync();
        }
    }
}
