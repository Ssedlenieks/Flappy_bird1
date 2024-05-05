using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Flappy_bird1.Registration_Window;
using static Flappy_bird1.Form1;
namespace Flappy_bird1
{
    public class Player : User 
    {
        public static int Player_Count = 0;
        public int Player_ID { get; set; }
        public string Player_Name { get; set; }
        public string Player_Password { get; set; } 
        public int Player_Score { get; set; }
        public Player(int player_ID, string Username, string Password, int Score) : base(Username, Password, Score)
        {
            Player_ID = player_ID; 
            Player_Name = Username;
            Player_Password = Password;
            Player_Score = Score;
            Player_Count++;
        }
    } 
}