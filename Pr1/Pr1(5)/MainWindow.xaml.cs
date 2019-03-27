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

namespace Pr1_5_
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (temper.Text != "" && action.Text != "")
            {
                if (action.Text == "Cooling")
                {
                    CoolingFactory cf = new CoolingFactory();
                    res.Text += cf.Create(Convert.ToSingle(temper.Text)).Operate();
                    action.Text = "";
                    temper.Text = "";
                }
                else
                {
                    WarmingFactory wm = new WarmingFactory();
                    res.Text += wm.Create(Convert.ToSingle(temper.Text)).Operate();
                    action.Text = "";
                    temper.Text = "";
                }
            }
            }
    }
}
