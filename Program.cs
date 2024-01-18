using Mission_2_Dice_Throwing_Simulator;

internal class Program
{
    private static void Main(string[] args)
    {
        //variables
        int numRoll = 0;
        int[] aiOutput = [];

        //object
        Simulator diceRoller = new Simulator();

        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");

        //user input 
        numRoll = int.Parse(System.Console.ReadLine());
        aiOutput = diceRoller.RollDice(numRoll);

        //DICE ROLLING SIMULATION RESULTS
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1 % of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = "+ numRoll + ".");

        //display the result
        for (int i = 2; i < 13; i ++)
        {
            Console.WriteLine(i + ": ");
            int percentage = aiOutput[i - 2] * 100 /numRoll;
            Console.WriteLine(new String('*', percentage));
        }


        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye");

    }
}