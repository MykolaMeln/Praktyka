using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Pr2_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /*private RadioButton rbn()
        {
            RadioButton rb = vol1;
                if (vol1.IsChecked == true)
                {
                    rb = vol1;
                }
                else if (vol2.IsChecked == true)
                {
                    rb = vol2;
                }
                else if (vol3.IsChecked == true)
                {
                    rb = vol3;
                }
                else if (vol4.IsChecked == true)
                {
                    rb = vol4;
                }          
                return rb;
        }
       */
        private void volume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RadioButton rb = vol1;
            if (vol1.IsChecked == true)
            {
                rb = vol1;
            }
            else if (vol2.IsChecked == true)
            {
                rb = vol2;
            }
            else if (vol3.IsChecked == true)
            {
                rb = vol3;
            }
            else if (vol4.IsChecked == true)
            {
                rb = vol4;
            }

            (new Thread(() =>
            {
                Volume singleton1 = Singleton.GetInstance();
            })).Start();
            Volume singleton2 = Singleton.GetInstance();
            singleton2.Name = rb.Content.ToString();
            singleton2.Value = Convert.ToInt32(volume.Value);
            data.ItemsSource = singleton2.Changed().table().DefaultView;
        }
    }
}
