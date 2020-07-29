using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17.Classes
{
    class Player
    {
        public int PlayerNumber { get; set; }
        public int VictoryPoints { get; set; }
        public List<Unit> Units { get; set; }

        public Player(int playerNumber)
        {
            this.PlayerNumber = playerNumber;
            this.VictoryPoints = 0;
            this.Units = new List<Unit>();
        }

        public List<string> PrintUnits()
        {
            List<string> result = new List<string>();
            foreach (var item in this.Units)
            {                
                result.Add(item.UnitName + " There are currently " + item.NumberOfModels + " fighters remaining in this unit, and you have " + this.VictoryPoints + " victory points.");
            }
            return result;
        }
    }
}
