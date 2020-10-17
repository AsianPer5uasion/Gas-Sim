using System;
using System.Collections.Generic;
using System.Linq;
using SharpGL;

namespace Gas_Simulator
{
    class ObjectModel3D
    {
        // properties possessed by an ObjectModel3D
        public double[][] Vertices { get; }
        public int[][] Triangles { get; }

        // construct an ObjectModel3D from an array of vertices
        ObjectModel3D(double[][] vertices, int[][] triangles)
        {
            Vertices = vertices;
            Triangles = triangles;
        }

        // load a 3d object from a .obj file !! ASSUMES MODEL IS TRIANGULATED
        public static ObjectModel3D LoadFromFile(string filepath)
        {
            List<double[]> vertices = new List<double[]>();
            List<int[]> triangles = new List<int[]>();
            string[] lines = System.IO.File.ReadAllLines(filepath);

            foreach (var line in lines)
            {
                string[] s = line.Split(' ');
                
                if (s[0] == "v")
                {
                    double[] values = s.Skip(1).Take(3).Select(x => Convert.ToDouble(x)).ToArray();
                    vertices.Add(values);

                } else if (s[0] == "f")
                {
                    int[] values = s.Skip(1).Take(3).Select(x => Convert.ToInt32(x.Split('/')[0])).ToArray();
                    triangles.Add(values);
                }
            }

            return new ObjectModel3D(vertices.ToArray(), triangles.ToArray());
        }

        // draw a 3d model
        public void Draw(OpenGL gl)
        {

            gl.Color(1.0f, 0.0f, 0.0f);
            
            foreach (int[] tri in Triangles)
            {
                foreach (int v_index in tri)
                {
                    gl.Vertex(Vertices[v_index-1]);
                }
            }
        }
    }
}
