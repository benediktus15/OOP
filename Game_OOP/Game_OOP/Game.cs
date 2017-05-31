using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_OOP
{
    class Game
    {
        static void Main(string[] args)
        {
            //call map
            Map map = new Map(8, 5);

            //Console.WriteLine(map.Height * map.Width);

            //point
            //Point point = new Point(4, 2);
            //bool isOnMap = map.onMap(point);
            //Console.WriteLine(isOnMap);

            //Console.WriteLine(point.distanceTo(4, 3));

            //map_location : inharitance
            try
            {
                //MapLocation point2 = new MapLocation(8, 5, map);
                //isOnMap = map.onMap(point2);
                //Console.WriteLine(isOnMap);
                //Console.WriteLine(point2.distanceTo(7, 5));

                //Console.WriteLine(point2 is Point); //ngecek if

                Path path = new Path(new[]
                {
                    new MapLocation(0, 2, map),
                    new MapLocation(1, 2, map),
                    new MapLocation(2, 2, map),
                    new MapLocation(3, 2, map),
                    new MapLocation(4, 2, map),
                    new MapLocation(5, 2, map),
                    new MapLocation(6, 2, map),
                    new MapLocation(7, 2, map)
                });

                Invader[] invaders =
                {
                    new StrongInvader(path),
                    new ShieldedInvader(path),                    
                    new FastInvader(path),
                    new Invader(path)
                };

                Tower[] towers =
                {
                    new Tower(new MapLocation(1,3,map)),
                    new Tower(new MapLocation(4,2,map)),
                    new Tower(new MapLocation(5,3,map))
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerStatus = level.Play();
                Console.WriteLine("Player " + (playerStatus ? "won" : "lost"));

                //MapLocation location = path.getLocationAt(0);
                //MapLocation location = new MapLocation(0, 2, map);
                //Console.WriteLine(location.X + "," + location.Y);
            }

            catch (OutOfBaoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (MDException ex)
            {
                Console.WriteLine("Exception Level 2" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Level 3" + ex.Message);
            }
        }
    }
}
