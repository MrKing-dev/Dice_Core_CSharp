using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Dice_Core
{
    internal class Dice
    {
        public List<int> Roll(int sides, int quan)
        {
            Random rnd = new Random();
            List<int> dice = new List<int>();
            for(int i = 0; i < quan; i++)
            {
                dice.Add(rnd.Next(1, sides + 1));
            }
            return dice;
        }
    }
}
