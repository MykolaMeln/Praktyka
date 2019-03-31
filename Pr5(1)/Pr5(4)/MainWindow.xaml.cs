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

namespace Pr5_4_
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
            IPersonage personage = null ;
            IWeapon weapon = null;
            ITeam team = null;

            if(king.IsChecked==true)
            {
                personage = new King();
            }
            else if(queen.IsChecked == true)
            {
                personage = new Queen();
            }
            else if(knight.IsChecked == true)
            {
                personage = new Knight();
            }
            else if(troll.IsChecked == true)
            {
                personage = new Troll();
            }

            if(sword.IsChecked == true)
            {
                weapon = new Sword();
            }
            else if (bow.IsChecked == true)
            {
                weapon = new Bow();
            }
            else if (arbalet.IsChecked == true)
            {
                weapon = new Arbalet();
            }


            if (red.IsChecked == true)
            {
                team = new Red();
            }
            else if (green.IsChecked == true)
            {
                team = new Green();
            }
            else if (blue.IsChecked == true)
            {
                team = new Blue();
            }
            else if (yellow.IsChecked == true)
            {
                team = new Yellow();
            }

            Character character = new Character(personage, weapon, team);
            MessageBox.Show(character.ShowCharacter());
            king.IsChecked = false;
            queen.IsChecked = false;
            knight.IsChecked = false;
            troll.IsChecked = false;
            sword.IsChecked = false;
            bow.IsChecked = false;
            arbalet.IsChecked = false;
            red.IsChecked = false;
            green.IsChecked = false;
            blue.IsChecked = false;
            yellow.IsChecked = false;
       
        }
    }
}
