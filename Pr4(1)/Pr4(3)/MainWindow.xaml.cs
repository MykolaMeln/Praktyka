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

namespace Pr4_3_
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
            string c = calendar.SelectedDate.ToString();
            string s = c.Substring(0, 2);

            string n = DateTime.Now.ToString();
            string t = n.Substring(0, 2);
            if (Convert.ToInt32(s) >= Convert.ToInt32(t))
            {
                CustomerStructure cs = new CustomerStructure();

                cs.Add(new Customer1(calendar.SelectedDate.ToString()));
                cs.Add(new Customer2(calendar.SelectedDate.ToString()));
                cs.Add(new Customer3(calendar.SelectedDate.ToString()));

                Director1 dir1 = new Director1();
                Director2 dir2 = new Director2();
                pr1.Text = cs.Accept(dir1);
                pr2.Text = cs.Accept(dir2);
                pr3.Text = cs.Accept(dir1);
            }
            else
                MessageBox.Show("Виберіть дату не в минулому!");
        }
    }
}
