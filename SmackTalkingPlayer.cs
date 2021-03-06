using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        List<string> TauntList = new List<string>()
        {
            "Watching you try to play dice is like watching a baby smoke a cigarette -- it's kind of cool, but also very disturbing",
            "You have delusions of adequacy.",
            "I like the way you try.",
            "if I throw a stick, will you leave?"
        };

        public int TauntRoll()
        {
            return new Random().Next(0, TauntList.Count);
        }

        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();
            int index = TauntRoll();
            string Taunt = TauntList[index];

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