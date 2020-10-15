using System;

namespace Gas_Simulator
{
    public struct Vector
    {
        // values contained by the vector
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // vector constructor
        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        // useful static methods
        public static Vector Zero() => new Vector(0, 0, 0); // create a vector where all values are zeros
        public static double Dot(Vector a, Vector b) => throw new NotImplementedException();
        public static Vector Cross(Vector a, Vector b) => throw new NotImplementedException();

        // calculate the scalar magnitude of the vector
        public double Magnitude() => Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));

        // angle calculations
        public double AngleX() => Math.Atan2(Math.Sqrt(Math.Pow(Y, 2) + Math.Pow(Z, 2)), X);
        public double AngleY() => Math.Atan2(Math.Sqrt(Math.Pow(Z, 2) + Math.Pow(X, 2)), Y);
        public double AngleZ() => Math.Atan2(Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)), Z);

        // overloading operators to make them function correctly between scalar and vector values
        public static Vector operator *(Vector a, double b) => new Vector(a.X * b, a.Y * b, a.Z * b);
        public static Vector operator *(Vector a, int b) => new Vector(a.X * b, a.Y * b, a.Z * b);
        public static Vector operator +(Vector a, Vector b) => new Vector(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        public static Vector operator -(Vector a, Vector b) => new Vector(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

        // output vectors nicely as strings
        public override string ToString() => $"({X}, {Y}, {Z})";
    }
}