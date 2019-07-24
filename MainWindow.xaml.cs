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
            Thread thread = new Thread();


            InitializeComponent();
        }


        private void Cropbutton_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Fishbutton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Shopbutton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MoneyLable_TextInput(object sender, TextCompositionEventArgs e)
        {
            this.moneyLable.Content = "46418964";
        }
    }
}
