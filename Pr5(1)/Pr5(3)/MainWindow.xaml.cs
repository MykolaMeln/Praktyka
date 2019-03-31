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

namespace Pr5_3_
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
        private Ticket ticket;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool vikn = false;
            bool ret = false;
            if (clas.Text != "")
            {
                if (clas.SelectedIndex == 3)
                {
                    if (vikno.IsChecked == true)
                    {
                        vikn = true;
                        ticket = new Ticket(new Hot(), true, false);
                    }
                    else
                    {
                        ticket = new Ticket(new Hot(), false, false);
                    }
                }
                else if (clas.SelectedIndex == 0)
                {
                    if (vikno.IsChecked == true)
                    {
                        vikn = true;
                        ticket = new Ticket(new Ekonom(), true, false);
                    }
                    else if (zdacha.IsChecked == true)
                    {
                        ret = true;
                        ticket = new Ticket(new Ekonom(), false, true);
                    }
                    else if (zdacha.IsChecked == true && vikno.IsChecked == true)
                    {
                        vikn = true;
                        ret = true;
                        ticket = new Ticket(new Ekonom(), true, true);
                    }
                    else
                    {
                        vikn = false;
                        ret = false;
                        ticket = new Ticket(new Ekonom(), false, false);
                    }
                }
                else if (clas.SelectedIndex == 2)
                {
                    if (vikno.IsChecked == true)
                    {
                        vikn = true;
                        ticket = new Ticket(new First(), true, false);
                    }
                    else if (zdacha.IsChecked == true)
                    {
                        vikn = true;
                        ret = true;
                        ticket = new Ticket(new First(), false, true);
                    }
                    else if (zdacha.IsChecked == true && vikno.IsChecked == true)
                    {
                        ret = true;
                        ticket = new Ticket(new First(), true, true);
                    }
                    else
                    {
                        vikn = false;
                        ret = false;
                        ticket = new Ticket(new First(), false, false);
                    }
                }
                else if (clas.SelectedIndex == 1)
                {
                    if (vikno.IsChecked == true)
                    {
                        vikn = true;
                        ticket = new Ticket(new Business(), true, false);
                    }
                    else if (zdacha.IsChecked == true)
                    {
                        ret = true;
                        vikn = true;
                        ticket = new Ticket(new Business(), false, true);
                    }
                    else if (zdacha.IsChecked == true && vikno.IsChecked == true)
                    {
                        ret = true;
                        ticket = new Ticket(new Business(), true, true);
                    }
                    else
                    {
                        vikn = false;
                        ret = false;
                        ticket = new Ticket(new Business(), false, false);
                    }
                }
                MessageBox.Show("Ваш білет: " + ticket.clas.GetType().ToString().Substring(7) + " Біля вікна: " + vikn + " Повернення: " + ret + " Цiна: " + ticket.Vartist().ToString());
                clas.Text = "";
                zdacha.IsChecked = false;
                vikno.IsChecked = false;
            }
            else
                MessageBox.Show("Оберiть бiлет!");
        }

        private void clas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (clas.SelectedIndex == 3)
            {
                zdacha.IsChecked = false;
                zdacha.IsEnabled = false;
            }
            else
                zdacha.IsEnabled = true;
        }
    }
}
