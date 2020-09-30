using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Final_Project
{
    public class Game
    {
        public static void Main()
        {
            new Player();

            new Enemy();

            new Game_Room();

            Update();
            Console.Write(Game_Room.Nr_rooms.ToString());
            Player.Player_HP = Player.Player_HP - 10;
            Console.ReadLine();
            Update();
            Console.Read();
            // lägg till startfunktion
        }
        public static void Update()
        {
            Player.Level();
            Interface.Update_Interface();
        }
        
    }
}
