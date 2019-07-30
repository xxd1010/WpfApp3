using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

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
        public string buttonContentLand = "土地";
        public string buttonContentFish = "鱼塘";
        public string buttonContentShop = "商店";
        

        public void MainWindowColorChange()
        {
            //MainwinDows所有button的颜色;



            //MainWindow所有Grid的颜色
            
            //cropbutton.Background = ;


            //crop_fish_shop_Grid.Background = cropbutton.Background;
            //crop_fish_shop_Grid.Background = fishbutton.Background;
            //crop_fish_shop_Grid.Background = shopbutton.Background;





        }


        private void Landbutton_Click(object sender, RoutedEventArgs e)
        {

            item1Tab.Header = buttonContentLand;
            //crop_fish_shop_Grid.Visibility = Visibility.Visible;
            //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;
            //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;
            crop_fish_shop_TXT.Text = buttonContentLand;
        }

        private void Fishbutton_Click(object sender, RoutedEventArgs e)
        {

            item1Tab.Header = buttonContentFish;
            //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;
            //crop_fish_shop_Grid.Visibility = Visibility.Visible;
            //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;
            crop_fish_shop_TXT.Text = buttonContentFish;
        }

        private void Shopbutton_Click(object sender, RoutedEventArgs e)
        {

            item1Tab.Header = buttonContentShop;
            //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;
            //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;
            //crop_fish_shop_Grid.Visibility = Visibility.Visible;
            crop_fish_shop_TXT.Text = buttonContentShop;
        }
    }
}
