using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;
        // variables are private by default
        // Width and Height do not change after they are created

        // void means the method doesn't return anything

        // Map constructor
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return
                point.X >= 0 && point.X < Width &&
                point.Y >= 0 && point.Y < Height;
        }
    }
}
