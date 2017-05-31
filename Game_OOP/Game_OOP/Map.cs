using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_OOP
{
    class Map
    {
        public readonly int Height;
        public readonly int Width;

        public Map(int width, int height)
        {
            Height = height;
            Width = width;            
        }

        //point
        public bool onMap(Point point)
        {
            //var inBounds = point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;

            //return inBounds;

            var panjang = point.X < Width && point.X >= 0;
            var lebar = point.Y < Height && point.Y >= 0;

            return panjang && lebar;
        }
    }
}
