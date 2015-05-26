using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Battle_In_The_Sea.Interfaces
{
    interface Battleship
    {
        int GetSize();
        void SetLocation(int location);
        Boolean IsHit(int location);
    }
}
