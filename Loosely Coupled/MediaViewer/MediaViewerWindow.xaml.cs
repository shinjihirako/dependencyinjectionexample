using MediaViewer.Presentation;
using System.Windows;

namespace MediaViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MediaViewerWindow : Window
    {
        MediaViewModel viewModel;
        public MediaViewerWindow(MediaViewModel mediaViewModel)
        {
            InitializeComponent();
            viewModel = mediaViewModel;
            this.DataContext = viewModel;
        }

        private void FetchMediaButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.RefreshMedia();
            ShowRepositoryType();
        }

        private void ClearMediaButton_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ClearMedia();
            ClearRepositoryType();
        }

        private void ShowRepositoryType()
        {
          //  RepositoryTypeTextBlock.Text = viewModel.DataReaderType;
        }

        private void ClearRepositoryType()
        {
         //   RepositoryTypeTextBlock.Text = string.Empty;
        }

    }
}
