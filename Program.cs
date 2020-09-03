using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            SmackTalkingPlayer smack = new SmackTalkingPlayer();
            smack.Name = "Silky Johnson";

            OneHigherPlayer oneHigher = new OneHigherPlayer();
            oneHigher.Name = "OneUp Willy";


            HumanPlayer hooman = new HumanPlayer();
            hooman.Name = "I is Hooman";


            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            smack.Play(oneHigher);
            Console.WriteLine("-------------------");
            hooman.Play(smack);
            Console.WriteLine("-------------------");
            oneHigher.Play(hooman);
            Console.WriteLine("-------------------");
            large.Play(oneHigher);
            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                smack, oneHigher, hooman, large
            };

            // PlayMany(players);
        }

        // static void PlayMany(List<Player> players)
        // {
        //     Console.WriteLine();
        //     Console.WriteLine("Let's play a bunch of times, shall we?");

        //     // We "order" the players by a random number
        //     // This has the effect of shuffling them randomly
        //     Random randomNumberGenerator = new Random();
        //     List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

        //     // We are going to match players against each other
        //     // This means we need an even number of players
        //     int maxIndex = shuffledPlayers.Count;
        //     if (maxIndex % 2 != 0)
        //     {
        //         maxIndex = maxIndex - 1;
        //     }

        //     // Loop over the players 2 at a time
        //     for (int i = 0; i < maxIndex; i += 2)
        //     {
        //         Console.WriteLine("-------------------");

        //         // Make adjacent players play noe another
        //         Player silkyJohnson = shuffledPlayers[i];
        //         Player oneHigher = shuffledPlayers[i + 1];
        //         silkyJohnson.Play(oneHigher);
        //     }
        // }
    }
}