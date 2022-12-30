using M322_WP.Repositories;

namespace M322_WP;

public partial class Settings : ContentPage
{
    public Settings()
    {
        InitializeComponent();
        BindingContext = new SettingsRepository().SettingEntries;
    }
    
    private async void NavigateInfo(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("info");
    }
}