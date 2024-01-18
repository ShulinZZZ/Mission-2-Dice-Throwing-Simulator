using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2_Dice_Throwing_Simulator
{
    internal class Simulator
    {
        //generate random numbers for the dice
        private Random Random = new Random();
        int[] countResults = new int[11];

        public Simulator() 
        {
        }
        public int[] RollDice(int numRoll)
        {
            for(int i = 0; i< numRoll; i++)
            {
                int diceOne = Random.Next(1, 7);
                int diceTwo = Random.Next(1, 7);
                int sumResult = diceOne + diceTwo;
                countResults[sumResult-2]++;

            }
            return countResults;
        }
    }
}
