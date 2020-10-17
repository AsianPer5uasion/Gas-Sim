using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Simulator
{
    class Container
    {
        // properties possessed by a container
        public ObjectModel3D ObjectModel { get; }
        public List<Molecule> Molecules { get; set; }

        // create a new container with the shape of the object in objectmodelfile.obj containing molcount molecules
        Container(string objectmodelfile, int molcount)
        {
            ObjectModel = ObjectModel3D.LoadFromFile(objectmodelfile);

            for (int i = 0; i < molcount; i++)
            {
                Molecules.Add(new Molecule(this)); // JUST FOR TESTING, USE OTHER MOLECULE CONSTRUCTOR
            }
        }

        // check if a point is within the container >> used to detect collision with container walls
        public bool isContained(Vector pos)
        {
            return pos.X < 5;
        }
    }
}
