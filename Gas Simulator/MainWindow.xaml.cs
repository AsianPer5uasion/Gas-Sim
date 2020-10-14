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

namespace Gas_Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Molecule[] molecules = new Molecule[10];

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++ )
            {
                molecules[i] = new Molecule();
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Molecule {i+1}:\r\n" + molecules[i].ToString());
            }
        }
    }
}
