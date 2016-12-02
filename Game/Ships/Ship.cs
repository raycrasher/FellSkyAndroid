using FellSky.Framework;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FellSky.Game.Ships
{
    public class Ship
    {
        public class Component
        {

        }

        public string SpriteId { get; set; }
        public List<Hardpoint> Hardpoints { get; set; } = new List<Hardpoint>();
    }
}
