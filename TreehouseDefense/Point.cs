using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        // Point Constructor
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return X + "," + Y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point))
            {
                return false;
            }

            Point that = obj as Point;

            return this.X == that.X && this.Y == that.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode();
        }

        public int DistanceTo(int x, int y)
        {
            /**********************************************************
             * THE BELOW IS A LONGER WAY TO WRITE WHAT IS UNCOMMENTED *
             * The formula for Cartesian distance                     *
             * (The square root of the sum of the squared differences *
             * of the X and Y coordinates                             *
             **********************************************************
             int xDiff = X - x;
             int yDiff = Y - y;
             int xDiffSquared = xDiff * xDiff;
             int yDiffSquared = yDiff * yDiff;
             return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
             */

            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        // Overloading a constructor with one parameter
        public int DistanceTo(Point point)
        { 
            return DistanceTo(point.X, point.Y);
        }
            
             
        
    }
}
