using System;

namespace Gas_Simulator
{
    class Molecule
    {
        public Point Pos { get; }
        public Velocity Velocity { get; }
        public Acceleration Acceleration { get; }
        public double Mass { get; }
        public double Volume { get; }

        public Molecule()
        {
            Pos = new Point(0, 0, 0);
            Velocity = new Velocity(1, 0, 0);
            Acceleration = new Acceleration(0, 0, 0);
            Mass = 1.0;
            Volume = 1.0;
        }

        public Molecule (Velocity velocity, Acceleration acceleration, double mass, double volume)
        {
            Pos = new Point(0, 0, 0);
            Velocity = velocity;
            Acceleration = acceleration;
            Mass = mass;
            Volume = volume;
        }

        public Molecule(Point pos, Velocity velocity, Acceleration acceleration, double mass, double volume)
        {
            Pos = pos;
            Velocity = velocity;
            Acceleration = acceleration;
            Mass = mass;
            Volume = volume;
        }

        public override string ToString() => $"Position: {Pos}\r\nVelocity: {Velocity}\r\nAcceleration: {Acceleration}\r\nMass: {Mass}\r\nVolume: {Volume}\r\n";
    }
}