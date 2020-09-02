using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        List<string> Taunts = new List<string>()
        {
            "What can I say about your suit that can't be said about about Afghanistan. It looks bombed up and depleted.",
            "Now if you'll exuse me, I'm gonna go home and put water in Buck Nasty's mama's dish",
            "You oughtta take that cane, and beat whoever made that suit",
            "Where did you vaccuum your suit?"
        };
        
        public int TauntRoll()
        {
            return new Random().Next(0, Taunts.Count);
        }

        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();
            int index = TauntRoll();
            string Taunt = Taunts[index];

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            Console.WriteLine($@"{Name}: ""{Taunt}""");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
            }
            else
            {
                Console.WriteLine("It's a tie");
            }
        }
    }
}