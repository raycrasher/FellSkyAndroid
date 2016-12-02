using Artemis;
using FellSky.Game.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky
{
    public static class Extensions
    {
        public static T GetApi<T>(this Entity e)
            where T : IApi
        {
            return e.GetComponent<T>();
        }
    }
}
