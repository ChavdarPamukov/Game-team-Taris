using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUni_Battle_In_The_Sea.Forms;

namespace SoftUni_Battle_In_The_Sea.Classes.PlayerClasses
{
    class HumanPlayer : GenericPlayer
    {
        private PopupInputForm _inputForm = new PopupInputForm();

        public HumanPlayer()
        {
            base.SetIsHuman(true);
        }

        override public int ChooseHitLocation()
        {
            String input = "-1";
            String label = "Which box contains the enemy ship?\n26-50\nEnter 'exit' to quit\n";

            while (!IsInteger(input) || !IsValidHitLocation(input))
            {
                input = GetInputFromUser(label);
                if (input == "exit")
                {
                    input = "-2";
                    break;
                }
            }

            return int.Parse(input);
        }

        override public int GetLocationForShip()
        {
            String input = "-1";
            String label = "Which box should contain your ship?.\n1-25\nEnter 'exit' to quit\n";

            while (!IsInteger(input) || !IsValidShipLocation(input))
            {
                input = GetInputFromUser(label);
                if (input == "exit")
                {
                    input = "-2";
                    break;
                }
            }
            return int.Parse(input);
        }

        private bool IsValidHitLocation(String input)
        {
            int location = int.Parse(input);
            return (location >= 26 && location <= 50);
        }

        private bool IsValidShipLocation(String input)
        {
            int location = int.Parse(input);
            return (location >= 1 && location <= 25);
        }

        private String GetInputFromUser(String label)
        {
            this._inputForm.SetLabel(label);
            this._inputForm.ShowDialog();
            return this._inputForm.GetUserInput();
        }

        private bool IsInteger(String str)
        {
            try
            {
                int.Parse(str);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
