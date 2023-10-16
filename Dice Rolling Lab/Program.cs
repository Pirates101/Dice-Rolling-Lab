namespace Dice_Rolling_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int diceSides = GetValidNumber("What sided die would you like to roll? ");

                Console.WriteLine("Would You like to roll the dice? yes/no ");
                string anwser = Console.ReadLine();
                if (anwser.Equals("yes"))
                {
                        int sideOne = RollGenerator(diceSides);
                        int sideTwo = RollGenerator(diceSides);
            
                    if (diceSides == 6)
                    {
                        DiceRollSixValues(sideOne, sideTwo);
                        DiceRollSixTotals(sideOne, sideTwo);
                    }
                    else 
                    {
                        DiceRollOtherValues(sideOne, sideTwo);
                    }
            }
                Console.WriteLine("Continue? yes/no");

                string contAnwser = Console.ReadLine();
                if (contAnwser.Equals("yes"))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            
        }

        static int GetValidNumber(string initialMessage)
        {

            while (true)
            {
                Console.WriteLine(initialMessage);
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int result))
                {
                    return result; // we break out of the loop, AND the FUNCTION!
                }

                Console.WriteLine("Invalid input, try again");
            }
        }

        static int RollGenerator(int x)
        {
            Random diceRollGenerator = new Random();
            int diceRoll = diceRollGenerator.Next(0, x + 1);
            return diceRoll;
        }

        static void DiceRollSixValues(int x, int y)
        {
            Console.WriteLine($"You rolled {x} and {y} ({x + y} total)!");

            if (x == 1 && y == 1)
            {
                Console.WriteLine($"You rolled {x} and {y}. Snakeyes!");
            }
            else if ((x == 1 && y == 2) || (y == 1 && x == 2))
            {
                Console.WriteLine($"You rolled {x} and {y}. Ace deuce");
            }
            else if (x == 6 && y == 6)
            {
                Console.WriteLine($"You rolled {x} and {y}. Box cars!");
            }
            return;

        }

        static void DiceRollOtherValues(int x, int y)
        {
            Console.WriteLine($"You rolled {x} and {y} ({x + y} total)!");
            return;
        }
        static void DiceRollSixTotals(int x, int y)
        {

            if ((x + y == 7) ||(x + y == 11))
            {
                Console.WriteLine("You win! ");
            }
            else if ((x + y == 2) || (x + y == 3) || (x + y == 12))
            {
                Console.WriteLine("Craps!");
            }
            else if ((x + y) % 2 == 0)
            {
                Console.WriteLine("Evens!");
            }
            else if ((x + y) % 2 == 1)
            {
                Console.WriteLine("Odds!");
            }
            else
            {
                Console.WriteLine("  ");
            }
            return;
        }
        
    }
}