using M322_WP.Models;
using Microsoft.Maui.Handlers;

namespace M322_WP;

#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif


public partial class App : Application
{
    private const int WindowWidth = 390;
    private const int WindowHeight = 750;

    public App()
    {
        InitializeComponent();


        WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
        {
#if WINDOWS
            var mauiWindow = handler.VirtualView;
            var nativeWindow = handler.PlatformView;
            nativeWindow.Activate();
            IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
            WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
            AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
            appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
#endif
        });


        MainPage = new AppShell();
    }

    private async void navigateDashboard(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("dashboard");
    }

    private async void navigateAdd(object sender, EventArgs e)
    {
        var profile = new Profile(0, "", "edit_wp.png", "add_wp.png");
        var navigationParameter = new Dictionary<string, object>
        {
            {"Profile", profile}
        };
        await Shell.Current.GoToAsync("form", navigationParameter);
    }


    private async void NavigateSettings(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("settings");
    }

    private async void NavigateInfo(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("info");
    }
}