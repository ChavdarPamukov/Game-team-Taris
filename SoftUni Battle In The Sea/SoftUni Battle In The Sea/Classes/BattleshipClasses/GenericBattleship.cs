using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUni_Battle_In_The_Sea.Interfaces;

namespace SoftUni_Battle_In_The_Sea.Classes
{
    abstract class GenericBattleship : Battleship
    {
        private int _size;
        private int _location;

        public GenericBattleship()
        {

        }

        public int GetSize()
        {
            return this._size;
        }

        protected void SetSize(int size)
        {
            this._size = size;
        }

        public void SetLocation(int location)
        {
            if (location < 1 || location > 50)
            {
                throw new Exception("Can't set ship location. It must be > 1 && <= 50");
            }

            this._location = location;
        }

        public Boolean IsHit(int location)
        {
            if (location < 1 || location > 50)
            {
                throw new Exception("Can't check hit location. It must be > 1 && <= 50");
            }

            return this._location == location;
        }
    }
}
