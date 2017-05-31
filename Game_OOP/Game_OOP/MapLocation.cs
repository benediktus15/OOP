using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_OOP
{
    //bawahnya point
    class MapLocation : Point
    {
        public MapLocation(int x, int y,  Map map) : base (x, y)
        {
            if (!map.onMap(this))
                throw new Exception();
        }

        public bool inRangeOf(MapLocation mapLocation, int range)
        {
            return distanceTo(mapLocation) <= range;
        }

    }
}
