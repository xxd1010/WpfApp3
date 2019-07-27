using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp3.Create
{
    /// <summary>
    /// ControlsHide.xaml 的交互逻辑
    /// </summary>
    public partial class ControlsHide : Window
    {
        public ControlsHide()
        {
            InitializeComponent();
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            blueGrid.Visibility = Visibility.Collapsed;
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            //ControlsHide controlsHide = new ControlsHide();
            //controlsHide.IsEnabled = false;
            blueGrid.Visibility = Visibility.Visible;
        }

        


    }
}
