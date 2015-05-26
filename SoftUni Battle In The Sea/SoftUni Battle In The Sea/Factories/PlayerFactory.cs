using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUni_Battle_In_The_Sea.Interfaces;
using SoftUni_Battle_In_The_Sea.Classes.PlayerClasses;

namespace SoftUni_Battle_In_The_Sea.Factories
{
    class PlayerFactory
    {
        public static readonly PlayerFactory PLAYER_FACTORY = new PlayerFactory();

        private PlayerFactory()
        {
            //Private constructor
        }

        public Player BuildPlayer(String playerType)
        {
            if (playerType == null)
            {
                throw new Exception("playerType can't be null");
            }

            switch (playerType)
            {
                case "human":
                    return new HumanPlayer();
                case "computer":
                    return new ComputerPlayer();
                default:
                    throw new Exception("Can't create player. Invalid player type");
            }
        }
    }
}
