using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_OOP
{
    class Tower
    {
        private readonly MapLocation _location;
        private static Random randomGenerator = new Random();
        private const int _range = 1;
        private const int _power = 1;
        private const double _acuracy = 0.75;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireToInvader(Invader[] invaders)
        {
            foreach (var satuInvader in invaders)
            {
                if (satuInvader.IsActive && _location.inRangeOf(satuInvader.Location, _range)) //_range = 1, var baru 
                {
                    if (_acuracy >= randomGenerator.NextDouble())
                    {
                        satuInvader.decreasHealth(_power);
                        Console.WriteLine("Shoot on Invader Succes");

                        if (satuInvader.IsNeutralized)
                            Console.WriteLine("Invader died");
                    }
                    else
                        Console.WriteLine("Invader Shoot Lose");

                    break;
                }  
                       
            }

        }

    }

}
