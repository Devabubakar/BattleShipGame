
using BattleShipLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipLibrary
{
    public class GameLogic
    {

        public static void IntializeGridSpot(PlayerInfoModel model)
        {
            List<string> GridSpotLetters = new List<string>()
            {
                "A",
                "B",
                "C",
                "D",
                "E",
            };
            List<int> GridSpotNumbers = new List<int>()
            {
                1,
                2,
                3,
                4,
                5
            };

            foreach(string GridSpotLetter in GridSpotLetters)
            {
                foreach(int GridSpotNumber in GridSpotNumbers)
                {
                    AddGridSpot(model, GridSpotLetter, GridSpotNumber);
                }
            }

            
        }

        private static void AddGridSpot(PlayerInfoModel model, string GridSpotLetter, int GridSpotNumber)
        {
            GridSpotModel spot = new GridSpotModel()
            {
                SpotNumber = GridSpotNumber,
                SpotLetter = GridSpotLetter,
                Status = GridSpotStatus.Empty
            };

            model.ShipLocation.Add(spot);

         
           
        }

        public static bool PlaceShip (string shipPlacement, PlayerInfoModel model)
        {
            throw new NotImplementedException(); 
        }
    }
}
