using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipLibrary.Models
{
    public class PlayerInfoModel
    {
        public string? UserName { get; set; }

        public List<GridSpotModel> ShipLocation { get; set; } = new List<GridSpotModel>();

        List<GridSpotModel> ShotGrid { get; set; } = new List<GridSpotModel>(); 

    }
}
