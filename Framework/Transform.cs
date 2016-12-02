﻿using Artemis.Interface;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Framework
{
    public sealed class Transform: IComponent
    {
        public Vector2 Position { get; set; }
        public float Rotation { get; set; }
    }
}
