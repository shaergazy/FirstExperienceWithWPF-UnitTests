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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppForTPO;

namespace WPF_ТПО
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Area area = new Area();
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void ButtonForArea(object sender, RoutedEventArgs e)
        {


            resultLB.Content = area.AreaRectangle(Convert.ToInt32(heughtTB.Text), Convert.ToInt32(widthtTB.Text)).ToString();
        }
       
        

        private void ButtonAreaCircle(object sender, RoutedEventArgs e)
        {
            ПлощадьКруга.Content = area.AreaCircle(Convert.ToDouble(РадиусКруга.Text));
        }

        private void heughtTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    
}