using System;

namespace Gas_Simulator
{
    class Molecule
    {
        // DEFAULTS
        private const double DEFAULT_EP = 5.0;
        private const double DEFAULT_MASS = 1.0;
        private const double DEFAULT_RADIUS = 1.0;
        private const double DEFAULT_ELASTICITY = 0.5;

        // all properties possessed by a molecule object
        public Vector Pos { get; set; }
        public Vector Velocity { get; set; }
        public double Mass { get; set; }
        public double Radius { get; set; }
        public double EP { get; set; } // Potential Energy
        public double EK { get; } // Kinetic Energy
        public double Elasticity { get; set; }
        public double Momentum { get; }

        // default molecule, used for testing
        public Molecule()
        {
            Pos = new Vector(0, 0, 0);
            Velocity = new Vector(1, 0, 0);
            Mass = DEFAULT_MASS;
            Radius = DEFAULT_RADIUS;
            EP = DEFAULT_EP;
            Elasticity = DEFAULT_ELASTICITY;

            EK = 0.5 * Mass * Math.Pow(Velocity.Magnitude(), 2);
            Momentum = Mass * Velocity.Magnitude();
        }

        // molecule constructor, take arguments from sliders in the Gas Sim GUI
        public Molecule (Vector pos, Vector velocity, double mass, double radius, double ep, double elasticity)
        {
            Pos = pos;
            Velocity = velocity;
            Mass = mass;
            Radius = radius;
            EP = ep;
            Elasticity = (elasticity > 1.0) ? 1.0 : elasticity;

            EK = 0.5 * Mass * Math.Pow(Velocity.Magnitude(), 2);
            Momentum = Mass * Velocity.Magnitude();
        }

        // output the properties of the molecule as a string for debugging
        public override string ToString() => $"Position: {Pos}\r\nVelocity: {Velocity}\r\nMass: {Mass}\r\nRadius: {Radius}\r\n";

        // update velocity, position and kinetic energy based on delta time
        public void Update(double dt)
        {
            Pos += (Velocity * dt);
        }
    }
}