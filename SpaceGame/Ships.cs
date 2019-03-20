using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class Ships
    {
        public string name;
        public string description;
        
        public double warpSpeed;

        public List<Item> ship;

        public Ships(string name, string description, List<Item> items, double warpSpeed = 1.0)
        {
            this.name = name;
            this.description = description;
            this.warpSpeed = warpSpeed;
        }

        public double WarpSpeedLv(Ships speed)
        {
            return Math.Pow(warpSpeed, 10.0 / 3) + Math.Pow(10.0 - warpSpeed, -11.0 / 3);
        }

    }
}
