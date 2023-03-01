using Breakage.Data;
using System.Windows;

namespace Breakage.Windows
{
    /// <summary>
    /// Interaction logic for ChangeServiceWindow.xaml
    /// </summary>
    public partial class ChangeServiceWindow : Window
    {
        public ClientService ClientService { get; set; }

        public ChangeServiceWindow(ClientService service)
        {
            InitializeComponent();
            ClientService = service;
            DataContext = ClientService;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить?", "", MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                ClientService.Client.ClientService.Remove(ClientService);
                DialogResult = false;
                Close();
            }
        }
    }
}
