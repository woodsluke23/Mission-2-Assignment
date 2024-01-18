// Prompt the user for how many rolls and store the number to a variable and then parse it to an int

using Mission_2_Assignment;

public class Program
{
    public static void Main(string[] args)
    {
        DieClass rolls = new DieClass();

        Console.Write("How many times do you want to roll the dice? ");

        string InputOfRolls = Console.ReadLine();

        int NumOfRolls = int.Parse(InputOfRolls);

        int[] RollResults = rolls.RollDice(NumOfRolls);

        for (int i = 0; i < RollResults.Length; i++)
        {
            double percentage = (double)RollResults[i] / NumOfRolls * 100;
            string stars = new string('*', (int)percentage);

            Console.WriteLine($"{i + 2}: {percentage:F1}% {stars}");
        }
    }
}