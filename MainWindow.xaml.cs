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
            MainWindowColorChange();
            InitializeComponent();
        }


        public void MainWindowColorChange()
        {
            //MainwinDows所有button的颜色;



            //MainWindow所有Grid的颜色
            



            cropGrid.Background = cropbutton.Background;
            fishGrid.Background = fishbutton.Background;
            shopGrid.Background = shopbutton.Background;





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

        private void Croptxt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            croptxt.Text = "THIS IS CROP TXT AREA";
        }

        private void Fishtxt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            fishtxt.Text = "THIS IS FISH";
        }

        private void Shoptxt_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            shoptxt.Text = "this is SHOP";
        }
    }
}
