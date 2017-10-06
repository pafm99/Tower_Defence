using System;
namespace Tower_Defense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point (int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            //Cartisian Distance Formula (Long Version)
            int xDiff = X - x;
            int yDiff = Y - y;
            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;
            return (int)Math.Sqrt(xDiffSquared + yDiffSquared);

            //Cartisian Distance Formula (short version) Refactored Code
            //return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));

        }
        //Method Overloading 2 Methods with the same name but accept 2 different parameters
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }

    }












}