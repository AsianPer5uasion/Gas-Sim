using System;

namespace Gas_Simulator
{
    class Molecule
    {
        public Velocity Velocity { get; }
        public Acceleration Acceleration { get; }
        public double Mass { get; }
        public double Volume { get; }

        Molecule (Velocity v, Acceleration a, double m, double vol)
        {
            Velocity = v;
            Acceleration = a;
            Mass = m;
            Volume = vol;
        }
    }
}
