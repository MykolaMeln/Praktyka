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

namespace Pr2_3
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
            OrderedItems order = new OrderedItems();
            if(pepsi.IsChecked == true)
            {
                if(small.IsChecked == true)
                {
                    order.addItems(new SmallPepsi());
                }
                if (medium.IsChecked == true)
                {
                    order.addItems(new MediumPepsi());
                }
                if (large.IsChecked == true)
                {
                    order.addItems(new LargePepsi());
                }
            }
            if(coke.IsChecked == true)
            {
                if (small.IsChecked == true)
                {
                    order.addItems(new SmallCoke());
                }
                if (medium.IsChecked == true)
                {
                    order.addItems(new MediumCoke());
                }
                if (large.IsChecked == true)
                {
                    order.addItems(new LargeCoke());
                }
            }
            if(veg.IsChecked == true)
            {
                if (cheeze.IsChecked == true)
                {
                    if (smallp.IsChecked == true)
                    {
                        order.addItems(new SmallCheezePizza());
                    }
                    if (mediump.IsChecked == true)
                    {
                        order.addItems(new MediumCheezePizza());
                    }
                    if (largep.IsChecked == true)
                    {
                        order.addItems(new LargeCheezePizza());
                    }
                    if (extra_largep.IsChecked == true)
                    {
                        order.addItems(new ExtraLargeCheezePizza());
                    }

                }
                if (onion.IsChecked == true)
                {
                    if (smallp.IsChecked == true)
                    {
                        order.addItems(new SmallCheezePizza());
                    }
                    if (mediump.IsChecked == true)
                    {
                        order.addItems(new MediumCheezePizza());
                    }
                    if (largep.IsChecked == true)
                    {
                        order.addItems(new LargeCheezePizza());
                    }
                    if (extra_largep.IsChecked == true)
                    {
                        order.addItems(new ExtraLargeCheezePizza());
                    }

                }
                if (masala.IsChecked == true)
                {
                    if (smallp.IsChecked == true)
                    {
                        order.addItems(new SmallCheezePizza());
                    }
                    if (mediump.IsChecked == true)
                    {
                        order.addItems(new MediumCheezePizza());
                    }
                    if (largep.IsChecked == true)
                    {
                        order.addItems(new LargeCheezePizza());
                    }
                    if (extra_largep.IsChecked == true)
                    {
                        order.addItems(new ExtraLargeCheezePizza());
                    }

                }
            }
            if(non_veg.IsChecked == true)
            {
                if (smallp.IsChecked == true)
                {
                    order.addItems(new SmallNonVegPizza());
                }
                if (mediump.IsChecked == true)
                {
                    order.addItems(new MediumNonVegPizza());
                }
                if (largep.IsChecked == true)
                {
                    order.addItems(new LargeNonVegPizza());
                }
                if (extra_largep.IsChecked == true)
                {
                    order.addItems(new ExtraLargeNonVegPizza());
                }
            }

            MessageBox("Your order: /n"  + order.showItems());
        }

        private void non_veg_Checked(object sender, RoutedEventArgs e)
        {
            cheeze.IsEnabled = false;
            masala.IsEnabled = false;
            onion.IsEnabled = false;
        }
    }
}

