using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Simulator
{
    class ObjectModel3D
    {
        // properties possessed by an ObjectModel3D
        public Vector[] Vertices { get; }
        public Vector[] Triangles { get; }

        // construct an ObjectModel3D from an array of vertices
        ObjectModel3D(Vector[] vertices)
        {
            Vertices = vertices;
            Triangles = vertices; // calculate triangles
        }

        // load a 3d object from a .obj file
        public static ObjectModel3D LoadFromFile(string filepath) // IMPLEMENT THIS
        {
            throw new NotImplementedException();
        }
    }
}
