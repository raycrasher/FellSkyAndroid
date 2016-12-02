using Artemis;
using FellSky.Framework;
using FellSky.Game.Ships;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellSky.Game.Api
{
    public enum ShipCommand
    {
        SetThrustDir, MoveTo, SetTarget,
        UseAbility,
        DisableModule, EnableModule,     // module commands
        HoldFire, FireSalvo, FireAtWill, // weapon group commands
    }

    public class ShipApi: ITargetable, IApi
    {
        private Ship _ship;

        public Entity Entity { get; private set; }

        public Transform Transform
        {
            get { return Entity.GetComponent<Transform>(); }
            set { Entity.AddComponent(value); }
        }
        

        public ShipApi(Entity entity)
        {
            Entity = entity;
        }

        public bool Install(string hardpoint, IHardpointInstallable item)
        {
        }

        public bool Uninstall(string hardpoint)
        {

        }

        public bool Uninstall(IHardpointInstallable item)
        {

        }

        public void SetTarget(ITargetable target)
        {

        }

        public void SetThrustVector(Vector2 worldVector)
        {

        }

        public void MoveTo(Vector2 position)
        {

        }

        public void HoldFire(int weaponGroup = 0)
        {

        }

        public void FireAtWill(int weaponGroup = 0)
        {

        }

        public void FireSalvo(int weaponGroup = 0)
        {

        }



        // static methods

        public static ShipApi CreateShip(Ship ship)
        {

        }

        public static ShipApi CreateShip(string id)
        {

        }
    }
}
