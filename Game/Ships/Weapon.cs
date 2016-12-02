using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Game.Ships
{
    abstract class Weapon : IHardpointInstallable
    {
        public HardpointType HardpointType { get; set; }

        public int Size { get; set; }
    }
}
