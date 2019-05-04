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

namespace Пр6
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
            Vartist pos = new Posylka(misto1.Text, misto2.Text, Convert.ToDouble(vart.Text));
            endvart.Items.Add(pos.Info());

            if (str.IsChecked == true)
            {

                Strahovka strah = new Strahovka(true);
                strah.SetComponent(pos);

                endvart.Items.Add(strah.Info() + " " + strah.getVart());
            }
            else
            {
                Strahovka strah = new Strahovka(true);
                strah.SetComponent(pos);

                endvart.Items.Add(pos.Info()+ " " + strah.getVart());
            }
            
            ClassVidp vidpravka = new ClassVidp(clas.Text);
            vidpravka.SetComponent(pos);

            endvart.Items.Add(vidpravka.Info()+" "+vidpravka.getVart());
            endvart.Items.Add("Ватрiсть вiдправки: "+pos.getVart());

            misto1.Text = "";
            misto2.Text = "";
            vart.Text = "";
            str.IsChecked = false;
            clas.Text = "";
        }
    }
}
