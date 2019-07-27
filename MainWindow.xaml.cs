using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace WpfApp3
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Create.ControlsHide controlsHide = new Create.ControlsHide();
            //controlsHide.Show();
            InitializeComponent();
        }


        private void Cropbutton_Click(object sender, RoutedEventArgs e)
        {
            cropGrid.Visibility = Visibility.Visible;
            fishGrid.Visibility = Visibility.Collapsed;
            shopGrid.Visibility = Visibility.Collapsed;

        }

        private void Fishbutton_Click(object sender, RoutedEventArgs e)
        {
            cropGrid.Visibility = Visibility.Collapsed;
            fishGrid.Visibility = Visibility.Visible;
            shopGrid.Visibility = Visibility.Collapsed;
        }

        private void Shopbutton_Click(object sender, RoutedEventArgs e)
        {
            cropGrid.Visibility = Visibility.Collapsed;
            fishGrid.Visibility = Visibility.Collapsed;
            shopGrid.Visibility = Visibility.Visible;

        }


    }
}
