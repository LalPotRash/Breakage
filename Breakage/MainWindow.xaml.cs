using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace Breakage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frmMain.NavigationService.Navigate(new Pages.ClientsListPage());
            frmMain.Navigated += FrmMain_Navigated;
        }

        private void FrmMain_Navigated(object sender, NavigationEventArgs e)
        {
            btnGoBack.Visibility = frmMain.NavigationService.CanGoBack ? Visibility.Visible : Visibility.Collapsed;
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            frmMain.NavigationService.GoBack();       
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Shutdown(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Maximized(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void Minimized(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
