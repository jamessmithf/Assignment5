using Microsoft.UI.Xaml;
using Microsoft.UI.Windowing;
using Windows.Graphics;
using Microsoft.UI;  // Для управління розмірами вікна

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Assignment5.WinUI
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : MauiWinUIApplication
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            base.OnLaunched(args);

            // Отримуємо доступ до платформи Microsoft.UI.Xaml.Window
            var nativeWindow = Application.Windows[0].Handler.PlatformView as Microsoft.UI.Xaml.Window;

            if (nativeWindow != null)
            {
                // Отримуємо AppWindow для зміни розміру
                var windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
                var appWindow = AppWindow.GetFromWindowId(Win32Interop.GetWindowIdFromWindow(windowHandle));

                appWindow.Resize(new SizeInt32(650, 700));
            }
        }
    }

}
