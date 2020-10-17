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
        readonly string[] CONTAINER_SHAPES = { "", "", "" };

        // properties contained in a gas sim
        public int ContainerShape { get; set; }
        public int MoleculeCount { get; set; }
        public Container Container { get; set; }

        GasSim(int containershape, int moleculecount)
        {
            ContainerShape = containershape;
            MoleculeCount = moleculecount;

            Container = new Container(CONTAINER_SHAPES[ContainerShape], MoleculeCount);
        }
    }
}
