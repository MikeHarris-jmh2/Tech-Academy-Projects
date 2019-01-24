﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassesandObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid identifier = Guid.NewGuid();
            Console.WriteLine("Welcome to Grand hotel and Casino. Let's start by telling me your name.");
            string PlayerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}. Would you like to join a game of 21 right now?", PlayerName);
            string answer = Console.ReadLine().ToLower();
            if(answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(PlayerName, bank);
                player.Id = Guid.NewGuid();
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying == true && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");

            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }      
    }
}
