namespace M322_WP;

#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif


public partial class App : Application
{

    const int WindowWidth = 390;
    const int WindowHeight = 844;
    public App()
	{
		InitializeComponent();


        Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
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
        await Shell.Current.GoToAsync("form");
    }


    private async void navigateSettings(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("settings");
    }
}
