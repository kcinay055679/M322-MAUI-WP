namespace M322_WP;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("dashboard", typeof(Dashboard));
        Routing.RegisterRoute("form", typeof(FormPage));
        Routing.RegisterRoute("settings", typeof(Settings));
        Routing.RegisterRoute("info", typeof(InformationPage));
    }
}