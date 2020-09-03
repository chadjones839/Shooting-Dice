using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize plus 1
            return new Random().Next(DiceSize) + 2;
        }
    }
}