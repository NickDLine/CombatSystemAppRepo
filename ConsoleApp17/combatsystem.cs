using ConsoleApp17.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit cyberPunkDudes = new Unit(4, 3, 3, 2, 3, 30, "Cyberpunk Banditos");
            Unit corporateEnforcers = new Unit(6, 4, 4, 3, 2, 15, "MegaCorp Receptionists");
            Player playerOne = new Player(1);
            playerOne.Units.Add(cyberPunkDudes);
            Player playerTwo = new Player(2);
            playerTwo.Units.Add(corporateEnforcers);
            while (playerOne.VictoryPoints < 100 || playerTwo.VictoryPoints < 100)
            {
                bool playerOneTurn = true;
                if (playerOneTurn)
                {
                    Console.WriteLine("It is your turn! You are currently controlling:");
                    foreach (var item in playerOne.PrintUnits())
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("You attack!");

                }                
            }
            Console.WriteLine("GG Well Played!");
        }
        
        public int RNGenerator()
        {
            Random randomlyGeneratedNumber = new Random();
            return randomlyGeneratedNumber.Next(1, 10);            
        }

        // Attacks * NumberofModels = Number of attacks for whole unit [DONE]
        // if a roll is higher than WS, add one to new variable Hits
        // Compare your Strength to their Toughness with modifiers for higher or lower
        // Roll hits, see how many score wounds
        // Simple Version: Remove models of enemy based on wounds

    }
}
