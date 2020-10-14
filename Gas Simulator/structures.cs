using System;

namespace Gas_Simulator
{
    struct Velocity
    {
        Velocity (double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Magnitude() => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));

        public double X { get; }
        public double Y { get; }
        public double Z { get; }
    }

    struct Acceleration
    {
        Acceleration(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Magnitude() => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));

        public double X { get; }
        public double Y { get; }
        public double Z { get; }
    }
}