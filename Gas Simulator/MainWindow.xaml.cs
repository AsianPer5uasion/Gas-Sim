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
using SharpGL;

namespace Gas_Simulator
{
    /// <summary>
    /// Interaction logic for test.xaml
    /// </summary>
    public partial class test : Window
    {
        ObjectModel3D testobj = ObjectModel3D.LoadFromFile("../../sphere.obj");

        public test()
        {
            InitializeComponent();
        }

        private void openGLControl_OpenGLDraw(object sender, SharpGL.SceneGraph.OpenGLEventArgs args)
        {
            OpenGL gl = openGLControl.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.Begin(OpenGL.GL_TRIANGLES);

            testobj.Draw(gl);

            gl.End();
        }

        private void openGLControl_OpenGLInitialized(object sender, SharpGL.SceneGraph.OpenGLEventArgs args)
        {
           
            OpenGL gl = openGLControl.OpenGL;
            gl.ClearColor(0, 0, 0, 0);
        }

        private void openGLControl_Resized(object sender, SharpGL.SceneGraph.OpenGLEventArgs args)
        {

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);
            gl.LookAt(-5, 5, -5, 0, 0, 0, 0, 1, 0);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)

        {
            OpenGL gl = openGLControl.OpenGL;

            double sliderMult = slider1.Value / 10;   //0-10
            double rad = 15;
            double radSq = rad * rad;
            double x = 0; double z = 0;

            if (sliderMult < 0.5)
            {
                x = -1 * rad * (1 - sliderMult * 2);
            }
            else if (sliderMult > 0.5)
            {
                x = rad * (sliderMult - 0.5) * 2;
            }

            z = Math.Sqrt(radSq - (x * x));

            Console.WriteLine(sliderMult.ToString() + "   " + x + "   " + z);
            gl.LookAt(0, 0, 0, -x, 0, -z, 0, 1, 0);

        }

    }
}
