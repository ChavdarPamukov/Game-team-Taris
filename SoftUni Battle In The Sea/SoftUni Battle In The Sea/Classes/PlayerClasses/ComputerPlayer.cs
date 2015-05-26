using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Battle_In_The_Sea.Classes.PlayerClasses
{
    class ComputerPlayer : GenericPlayer
    {
        private Random _rndIntGen = new Random();

        public ComputerPlayer()
        {
            base.SetIsHuman(false);
        }

        override public int ChooseHitLocation()
        {
            return GetRandomNumberWithinBounds(1, 25);
        }

        override public int GetLocationForShip()
        {
            int location = -1;
            while (!ShipLocationIsValid(location))
            {
                location = GetRandomNumberWithinBounds(26, 50);
            }

            return location;
        }

        private int GetRandomNumberWithinBounds(int min, int max)
        {
            return this._rndIntGen.Next(min, max + 1);
        }

        private bool ShipLocationIsValid(int location)
        {
            if (location == -1)
            {
                return false;
            }

            for (int i = 0; i < base.GetBattleships().Length; i++)
            {
                if (base.GetBattleships()[i].IsHit(location))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
