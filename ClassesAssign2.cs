using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll_Assignment2
{
    internal class ClassesAssign2
    {
        // This method rolls the dice for how many times it is passed to it
        public int[] RollDice(int iNumRolls)
        {
            // Use the Random class for later
            Random rnd = new Random();

            // Reset array to hold zeros for the combination of two dice rolled
            int[] aiRollCount = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

            // Declare variable for each dice & Total
            int iFirstDice;
            int iSecondDice;
            int iRollLocation;

            // Loop through each roll for rolls passed
            for (int iCount = 0; iCount < iNumRolls; iCount++)
            {
                // Roll both dice
                iFirstDice = rnd.Next(1, 7);
                iSecondDice = rnd.Next(1, 7);
                // Add dice and subtract two for location
                iRollLocation = iFirstDice + iSecondDice - 2;
                // Add that roll to array (subtract 2 from roll number to get correct position)
                aiRollCount[iRollLocation] += 1;
            }

            // Return the array
            return aiRollCount;
        }
    }
}
