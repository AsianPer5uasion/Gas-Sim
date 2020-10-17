using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Simulator
{
    class GasSim
    {
        // files storing the possible container shapes
        readonly Dictionary<string, string> CONTAINER_SHAPE_FILES = new Dictionary<string, string>
        {
            { "cube", "" },
            { "sphere", "" },
            { "cylinder", "" }
        };

        // properties contained in a gas sim
        public string ContainerShape { get; set; }
        public int MoleculeCount { get; set; }
        public Container Container { get; set; }

        GasSim(string containershape, int moleculecount)
        {
            ContainerShape = containershape;
            MoleculeCount = moleculecount;

            Container = new Container(CONTAINER_SHAPE_FILES[ContainerShape], MoleculeCount);
        }
    }
}
