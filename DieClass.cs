using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2_Assignment
{
    internal class DieClass
    {
        public int [] RollDice(int NumOfRolls)
        {
            Random random = new Random();

            int[] RollCombos = new int[11];

            for (int i = 0; i < NumOfRolls; i++)
            {
                // Create an instance of the Random class
                int Die1 = random.Next(1, 7);
                int Die2 = random.Next(1, 7);
                int DieTotal = Die1 + Die2;
                RollCombos[DieTotal - 2]++;
            }
            return RollCombos;
        }
        
    }
}
