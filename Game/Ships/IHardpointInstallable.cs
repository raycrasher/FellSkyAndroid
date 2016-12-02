using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Game.Ships
{
    public interface IHardpointInstallable
    {
        HardpointType HardpointType { get; }
        int Size { get; }
    }
}
