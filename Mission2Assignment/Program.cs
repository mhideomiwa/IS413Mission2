// See https://aka.ms/new-console-template for more information

using Mission2Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        RollDice rd;
        rd = new RollDice();
        
        //Variables
        int[] rollCount = {0,0,0,0,0,0,0,0,0,0,0}; //count of how many times each one is rolled.
        // int[] rollCount = {0,0,0,0,0,0,0,0,0,0,0,0};
        int numRolls = 0;
        
        //Intro
        Console.WriteLine("Welcome to the dice throwing simulator!\n");
        
        Console.WriteLine("How many dice rolls would you like to simulate?");

        numRolls = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < numRolls; i++)
        {
            int roll = rd.Roll() - 2;
            rollCount[roll]++;
        }
        
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n" +
                          "Each \"*\" represents 1% of the total number of rolls.\n" +
                          "Total number of rolls = " + numRolls + "\n");
        
        for (int i = 0; i < rollCount.Length; i++)
        {
            int currentRoll = i + 2;
         
            //Percentage Math
            int rollPercent = 100 * rollCount[i] / numRolls;
            
            //Converting percentage into asterisks 
            string percentStars = "";
            for (int j = 0; j < rollPercent; j++)
            {
                percentStars = percentStars + "*";
            }
            
            Console.WriteLine(currentRoll + ": " + percentStars); 
        }
        

    }


}