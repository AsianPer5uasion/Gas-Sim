using System;

namespace Gas_Simulator
{
    struct Point
    {
        public Point (int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public override string ToString() => $"({X}, {Y}, {Z})";
    }

    struct Velocity
    { 
        public Velocity (double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Magnitude() => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));

        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public override string ToString() => $"({X}, {Y}, {Z})";
    }

    struct Acceleration
    {
        public Acceleration(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Magnitude() => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));

        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public override string ToString() => $"({X}, {Y}, {Z})";
    }
}