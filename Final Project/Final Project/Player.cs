using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Project
{
    public class Player
    {
        // obs! test data

        public static int Player_HP = 100;
        public static int Player_AD = 100;
        public static int Player_Armor = 100;
        public static string Player_Name;
        public static int Player_Level = 1;
        public static int Player_Exp = 0;
        
        public Player()
        {
            Console.SetCursorPosition(0, Console.WindowHeight / 3/2);
            Console.WriteLine("Welcome adventurer, what is thy name?");
            Player_Name = Console.ReadLine();
        }
        public static void Level() // kollar ifall spelaren har tillräkligt mycket exp för att gåupp en level
        {
            if ( Player_Exp >= 100)
            {
                Level_up();
            }
        }
        private static void Level_up() // Höjer spelarens level med 1
        {
            Player_Level++;
            Player_Exp -= 100;
            Player_HP += 20;
            Player_AD += 5;
            Player_Armor += 10;
        }
    }

}
