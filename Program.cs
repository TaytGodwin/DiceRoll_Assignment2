using DiceRoll_Assignment2;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        // Declare array to hold rolls & a variable to hold roll count
        int[] aiRollCount;
        int iRolls;
        // Variable to hold 
        Console.WriteLine("Welcome to the dice throwing simulator!" + Environment.NewLine + Environment.NewLine + "How many dice rolls would you like to simulate?");
        iRolls = int.Parse(Console.ReadLine());
        
        // Import the class
        ClassesAssign2 cls = new ClassesAssign2();
        // Get array from the RollDice method
        aiRollCount = cls.RollDice(iRolls);
        // Display the text before the asterisks
        Console.WriteLine(Environment.NewLine + "DICE ROLLING SIMULATION RESULTS" + Environment.NewLine + "Each \"*\" represents 1% of the total number of rolls."
            + Environment.NewLine + "Total number of rolls = " + iRolls + "." + Environment.NewLine + Environment.NewLine);
        // Use method below to print out correct number of asterisks in a loop
        for (int iCombination = 2; iCombination < 13; iCombination++)
        {
            Console.WriteLine($"{iCombination}: {GetAsterisks(aiRollCount[iCombination - 2], iRolls)}");
        }

        // Line break and end code with message
        Console.WriteLine(Environment.NewLine + Environment.NewLine + "Thank you for using the dice throwing simulator. Goodbye!");

    }

    // This method returns a string of asterisks for the percent of the total that was sent as a parameter
    private static string GetAsterisks(int iRolls, int iTotalRolls)
    {
        // Divide the iRolls by the iTotalRolls & times by 100 to get a percent and then round to integer
        int iNumAsterisks = (int)Math.Round((double)iRolls / iTotalRolls * 100);
        // Declare variable to hold asterisks
        string sAsterisks = "";
        // Loop through to add asterisks
        for (int iCount = 0; iCount < iNumAsterisks; iCount++)
        {
            if (sAsterisks != "")
            {
                sAsterisks += "*";
            } else
            {
                sAsterisks = "*";
            }
        }
        // Return the asterisks
        return sAsterisks;
    }
}