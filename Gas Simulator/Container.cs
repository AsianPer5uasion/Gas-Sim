using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_Simulator
{
    class Container
    {
        // check if a point is within the container -> used to detect collision with container walls
        public bool isContained(Vector pos)
        {
            return pos.X < 5;
        }
    }
}
