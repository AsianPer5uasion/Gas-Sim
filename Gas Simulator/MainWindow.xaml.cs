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
            Visuals visualsMain = new Visuals();
            for (int i = 0; i < 100; i++)
            {

                visualsMain.AddMolecule(i, 0, 0, 0.5, MainViewport);
                visualsMain.AddMolecule(0, i, 0, 0.5, MainViewport);
                visualsMain.AddMolecule(0, 0, i, 0.5, MainViewport);

            }
           
           
        }
     
    }
    
}