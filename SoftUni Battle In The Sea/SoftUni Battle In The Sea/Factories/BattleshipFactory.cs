using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUni_Battle_In_The_Sea.Interfaces;
using SoftUni_Battle_In_The_Sea.Classes.BattleshipClasses;
using SoftUni_Battle_In_The_Sea.Classes;

namespace SoftUni_Battle_In_The_Sea.Factories
{
    class BattleshipFactory
    {
        public static readonly BattleshipFactory BATTLESHIP_FACTORY = new BattleshipFactory();

        private BattleshipFactory()
        {
            //Private constructor
        }

        public Battleship BuildBattleship(int size)
        {
            if (size != 1 && size != 3 && size != 5)
            {
                throw new Exception("Invalid ship size. Size must be 1, 3 or 5");
            }

            switch (size)
            {
                case 1:
                    return new SmallBattleship();
                case 3:
                    return new MediumBattleship();
                case 5:
                    return new LargeBattleship();
                default:
                    throw new Exception("Something went terribly wrong with the ship sizes!");
            }
        }  
    }
}
