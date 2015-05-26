using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUni_Battle_In_The_Sea.Interfaces;

namespace SoftUni_Battle_In_The_Sea.Interfaces
{
    interface Player
    {
        int ChooseHitLocation();
        void CreateBattleships();
        bool IsHuman();
        int GetShipCount();
        int GetLocationForShip();
        Battleship[] GetBattleships();
    }
}
