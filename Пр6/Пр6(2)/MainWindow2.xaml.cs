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

namespace Пр6_2_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Travel travel = new Ticket(punkt.Text);
            result.Items.Add(travel.Info()+" "+travel.getVart());
            Move peres = new Move(peresuv.Text);
            peres.SetComponent(travel);
            result.Items.Add(peres.Info() + " " + peres.getVart());

            Dni den = new Dni(dni.Text);
            den.SetComponent(travel);
            result.Items.Add(den.Info() + " " + den.getVart());

            Hotel hotel = new Hotel(nomer.Text, vyd.Text);
            hotel.SetComponent(travel);
            result.Items.Add(hotel.Info() + " " + hotel.getVart());

            if (eks.IsChecked == true)
            {
                Ekskursii ekskurs = new Ekskursii(true);
                ekskurs.SetComponent(travel);

                result.Items.Add(ekskurs.Info() + " " + ekskurs.getVart());
            }
            else
            {
                Ekskursii ekskurs = new Ekskursii(false);
                ekskurs.SetComponent(travel);

                result.Items.Add(ekskurs.Info() + " " + ekskurs.getVart());
            }

            result.Items.Add("Ватрiсть подорожі: " + travel.getVart());

            punkt.Text = "";
            peresuv.Text = "";
            dni.Text = "";
            nomer.Text = "";
            vyd.Text = "";
            eks.IsChecked = false;
        }
    }
}
