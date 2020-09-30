using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;

namespace Final_Project
{
    public class Enemy
    {
        public static string Name;
        public static int HP;
        public static int Armor;
        public static int AD;
        //add multiple enemies with different stats 


        // följande voids bestämmer fiendens stats

        public Enemy()
        {
            Random random1 = new Random();
            int num = random1.Next(0, 100);
            Console.Write(num);

            if (num > 0 && num < 33)
            {
                Goblin(); // Väljer Goblin som motståndare och ger dess stats
            }
            else if (num > 32 && num < 66)
            {
                Orc(); // Väljer Orc som motståndare och ger dess stats
            }
            else if (num > 66 && num < 98) 
            {
                Witch(); // Väljer Witch som motståndare och ger dess stats
            }
            else
            {
                RaidBoss(); // Väljer RaidBoss som motståndare och ger dess stats
            }
        }


        // OBS! Test data för alla motståndare ändra senare för balancing 
        public static void Goblin()
        {
            Name = "Goblin";
            HP = 15;
            Armor = 5;
            AD = 10;
        }
        public static void Orc()
        {
            Name = "Orc";
            HP = 30;
            Armor = 12;
            AD = 18;
        }
        public static void Witch()
        {
            Name = "Witch";
            HP = 15;
            Armor = 2;
            AD = 40;
        }
        public static void RaidBoss()
        {
            Name = "RaidBoss";
            HP = 200;
            Armor = 100;
            AD = 60;
        }
    }
}
