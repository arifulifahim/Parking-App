using Microsoft.Maui.Controls;

namespace ParkingApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnLanguageSelected(object sender, EventArgs e)
        {
            if (sender is Button button && !string.IsNullOrEmpty(button.Text))
            {
                Preferences.Set("SelectedLanguage", button.Text);
                await Navigation.PushAsync(new LoginPage());
            }
        }
    }
}
