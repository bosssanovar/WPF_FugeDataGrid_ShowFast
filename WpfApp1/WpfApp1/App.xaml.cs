using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Media;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private async void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow2();
            mainWindow.WindowState = WindowState.Minimized;
            mainWindow.Show();

            var splash = new SplashScreen();
            splash.Show();

            Task.Delay(3000).Wait();

            splash.Close();
            mainWindow.WindowState = WindowState.Maximized;
        }
    }

}
