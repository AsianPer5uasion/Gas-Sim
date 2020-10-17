using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Media.Media3D;

namespace Gas_Simulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window

    {
        public Model3DGroup MainModel3Dgroup = new Model3DGroup();
        
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            test win2 = new test();
            win2.Show();
            slider1.Width = 300;
            slider1.Value = 0;

            Visuals visualsMain = new Visuals();
            for (int i = 0; i < 10; i++)
            {

                visualsMain.AddMolecule(i, 0, 0, 0.5, MainViewport, Brushes.Red);
                visualsMain.AddMolecule(0, i, 0, 0.5, MainViewport, Brushes.Blue);
                visualsMain.AddMolecule(0, 0, i, 0.5, MainViewport, Brushes.Green);
                visualsMain.AddMolecule(-i, 0, 0, 0.5, MainViewport, Brushes.Yellow);
                visualsMain.AddMolecule(0, -i, 0, 0.5, MainViewport, Brushes.Orange);
                visualsMain.AddMolecule(0, 0, -i, 0.5, MainViewport, Brushes.Pink);

            }
           
           
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)

        {
            double sliderMult = slider1.Value / 10;   //0-10
            double rad = 15;
            double radSq = rad * rad;
            double x=0; double z = 0;
       
            if (sliderMult < 0.5)
            {
                x = -1 * rad * (1 - sliderMult * 2);
            }
            else if (sliderMult > 0.5)
            {
                x = rad * (sliderMult - 0.5) * 2;
            }

            z = Math.Sqrt(radSq - (x * x));

            Console.WriteLine(sliderMult.ToString()+"   " + x + "   " + z);

            Main.LookDirection = new Vector3D(-x, 0, -z);
            Main.Position = new Point3D(x, 0, z);

        }
    }
    
}