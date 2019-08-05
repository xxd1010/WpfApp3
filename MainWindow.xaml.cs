using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Timers;


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

            //landbutton.Background = Color.FromRgb(0,0,255);


            //crop_fish_shop_Grid.Background = landbutton.Background;
            //crop_fish_shop_Grid.Background = fishbutton.Background;
            //crop_fish_shop_Grid.Background = shopbutton.Background;





        }



        private void Landbutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TabHeader();
                TxtText();
                Item2Visible();
                Item3Visible();





                void TabHeader()
                {
                    item1Tab.Header = buttonContentLand;
                }

                //crop_fish_shop_Grid.Visibility = Visibility.Visible;
                //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;
                //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;



                void TxtText()
                {
                    crop_fish_shop_TXT.Text = buttonContentLand;
                }

                void Item2Visible()
                {
                    item2Tab.Visibility = Visibility.Visible;
                }

                void Item3Visible()
                {
                    item3Tab.Visibility = Visibility.Visible;
                }
            }
            catch (System.Exception)
            {

                
            }
            

        }

        private void Fishbutton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TabHeader();
                TxtText();
                Item2Visible();
                Item3Visible();





                void TabHeader()
                {
                    item1Tab.Header = buttonContentFish;
                }

                //crop_fish_shop_Grid.Visibility = Visibility.Visible;
                //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;
                //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;



                void TxtText()
                {
                    crop_fish_shop_TXT.Text = buttonContentFish;
                }


                //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;
                //crop_fish_shop_Grid.Visibility = Visibility.Visible;
                //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;

                void Item2Visible()
                {
                    item2Tab.Visibility = Visibility.Hidden;
                }

                void Item3Visible()
                {
                    item3Tab.Visibility = Visibility.Hidden;
                }
            }
            catch (System.Exception)
            {

                
            }

            
            
        }

        private void Shopbutton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                TabHeader();
                TxtText();
                Item2Visible();
                Item3Visible();

                //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;
                //crop_fish_shop_Grid.Visibility = Visibility.Collapsed;
                //crop_fish_shop_Grid.Visibility = Visibility.Visible;


                // Tab的header
                void TabHeader()
                {
                    item1Tab.Header = buttonContentShop;
                }

                // ======end

                // 文本内容
                void TxtText()
                {
                    crop_fish_shop_TXT.Text = buttonContentShop;
                }

                // ======end

                // 设置itemTab的可见性
                void Item2Visible()
                {
                    item2Tab.Visibility = Visibility.Visible;
                }

                void Item3Visible()
                {
                    item3Tab.Visibility = Visibility.Visible;
                }

                // itemtab======end


            }
            catch (System.Exception)
            {

                
            }
            
            
        }
    }
}
