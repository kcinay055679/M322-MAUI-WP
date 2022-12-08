using Microsoft.Maui.Controls;

namespace M322_WP;

public partial class Dashboard : ContentPage
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void navigateSettings(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("settings");
    }

}