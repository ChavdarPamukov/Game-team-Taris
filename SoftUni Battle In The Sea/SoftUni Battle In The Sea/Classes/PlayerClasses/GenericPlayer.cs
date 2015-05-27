using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUni_Battle_In_The_Sea.Interfaces;
using SoftUni_Battle_In_The_Sea.Classes.BattleshipClasses;
using SoftUni_Battle_In_The_Sea.Factories;

namespace SoftUni_Battle_In_The_Sea.Classes.PlayerClasses
{
    abstract class GenericPlayer : Player
    {
        private readonly int[] _shipTypes = new int[] { 1 }; //This should be an Enum
        private readonly int _initialShipCount = 1;
        private Battleship[] _battleships;
        private bool _isHuman;

        public GenericPlayer()
        {

        }

        abstract public int ChooseHitLocation();
        abstract public int GetLocationForShip();

        public void CreateBattleships()
        {
            this._battleships = new Battleship[this._initialShipCount];
            int shipIndex = 0;
            for (int shipType = 0; shipType < this._shipTypes.Length; shipType++)
            {
                this._battleships[shipIndex] = BattleshipFactory.BATTLESHIP_FACTORY.BuildBattleship(this._shipTypes[shipType]);
                shipIndex++;
            }
        }

        public int GetShipCount()
        {
            return GetBattleships().Length;
        }

        public Battleship[] GetBattleships()
        {
            return this._battleships;
        }

        public bool IsHuman()
        {
            return this._isHuman;
        }

        protected void SetIsHuman(bool isHuman)
        {
            this._isHuman = isHuman;
        }
    }
}
