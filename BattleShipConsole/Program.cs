using BattleShipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleShipLibrary; 

namespace BattleShipConsole
{
     class Program
    {

        static void Main (string[] args)
        {
            WelcomeUser(); 

            PlayerInfoModel player1 =  CreatePlayer("Player 1");
            PlayerInfoModel player2 = CreatePlayer("Player 2");
              

        }

        private static void WelcomeUser()
        {
            Console.WriteLine("Welcome to BattleShip Application ");
            Console.WriteLine("Created by Abubakar Ali");
            Console.WriteLine();
        }

      
        private static PlayerInfoModel CreatePlayer(string PlayerTitle)
        {
            Console.WriteLine($"Player Information for {PlayerTitle}");

            PlayerInfoModel player = new PlayerInfoModel();

            player.UserName = RequestData("What is your User Name?:");

            GameLogic.IntializeGridSpot(player);

            PlaceShips(player);

            Console.Clear();

            return player; 
            


        }

        private static string RequestData(string message)
        {
            Console.Write(message);
            string? output = Console.ReadLine();
            return output; 
        }

        private static void PlaceShips(PlayerInfoModel player)
        {
            int shipPlacementCount = 0; 
            do
            {
                string shipPlacement = RequestData($"Enter ship placement for {shipPlacementCount / 5}: ");
                //check if it's valid or not 
                bool isValid = GameLogic.PlaceShip(shipPlacement, player);

                if (isValid == false )
                {
                    Console.WriteLine("Invalid Location , Please Enter the correct location in this range (A1-E5)");
                }


            } while (player.ShipLocation.Count < 5);

        }


    }
}
