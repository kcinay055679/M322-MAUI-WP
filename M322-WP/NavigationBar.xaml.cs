namespace M322_WP;

public partial class NavigationBar : ContentPage
{
	public NavigationBar()
	{
		InitializeComponent();
	}

    private async void navigateDashboard(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("dashboard");
    }

    private async void navigateAdd(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("form");
    }


    private async void navigateSettings(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("settings");
    }
}