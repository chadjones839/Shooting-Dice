using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class SmackTalker : Player
    {
        // List<string> Taunts = new List<string>()
        // {
        //     "Watching you try to play dice is like watching a baby smoke a cigarette -- it's kind of cool, but also very disturbing",
        //     "You have delusions of adequacy.",
        //     "I like the way you try.",
        //     "if I throw a stick, will you leave?"
        // };
        
        // public int TauntRoll()
        // {
        //     return new Random().Next(0, Taunts.Count);
        // }

        // public override void Play(Player other)
        // {
        //     int myRoll = Roll();
        //     int otherRoll = other.Roll();
        //     int index = TauntRoll();
        //     string Taunt = Taunts[index];

        //     Console.WriteLine($"{Name} rolls a {myRoll}");
        //     Console.WriteLine($"{other.Name} rolls a {otherRoll}");
        //     Console.WriteLine($@"{Name}: ""{Taunt}""");
        //     if (myRoll > otherRoll)
        //     {
        //         Console.WriteLine($"{Name} Wins!");
        //     }
        //     else if (myRoll < otherRoll)
        //     {
        //         Console.WriteLine($"{other.Name} Wins!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("It's a tie");
        //     }
        // }
    }
}