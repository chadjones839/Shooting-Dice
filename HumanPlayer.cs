using System;

namespace ShootingDice 
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Start:
            Console.Write("Enter a number for your roll:  ");
            string userInput = Console.ReadLine();
            bool RollNumber = int.TryParse(userInput, out int userRoll); 
            
            if (!RollNumber || userRoll < 1 || userRoll > 6)
            {
                Console.WriteLine("Rolls must be a number between 1 and 6");
                goto Start;
            }
            return userRoll;
        }
    }
}