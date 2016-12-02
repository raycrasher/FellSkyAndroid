using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Game.Ships
{
    public enum HardpointType
    {
        // weapon types
        Ballistic, Energy, Missile,
        // module types
        Power, Propulsion,
        Bay,
    }

    public class Hardpoint
    {
        public Vector2 Position { get; set; }
        public float Rotation { get; set; }
        public float Traverse { get; set; }
        public int Size { get; set; }
        public IHardpointInstallable Installed { get; set; }
    }
}
