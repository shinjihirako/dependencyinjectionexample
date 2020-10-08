using MediaViewer.CSV;
using MediaViewer.Presentation;
using MediaViewer.Service;
using System.Windows;

namespace MediaViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            CreateObjects();
            Application.Current.MainWindow.Title = "Dependency Injection Sample";
            Application.Current.MainWindow.Show();
        }

        private static void CreateObjects()
        {
            var reader = new CSVReader();
            var viewModel = new MediaViewModel(reader);
            Application.Current.MainWindow = new MediaViewerWindow(viewModel);
        }
    }
}
