using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flappy_bird1
{
    public class Player
    {
        public int Player_ID { get; set; }
        public string Player_Name { get; set; }
        public int Player_Score = 1;

        public static int PlayerCount = 0; 

        public Player(int player_ID, string player_Name, int player_Score)
        {
            Player_ID = player_ID; 
            Player_Name = player_Name;
            Player_Score = player_Score;
            PlayerCount++;
        }
    }
}
