﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Final_Project
{
    public class Interface
    {
        public Interface()
        {
           /* if (direction = "1")
            {
                // Välj alternativ 1 av flera.
            }*/
        }

        public static void Update_Interface()              // Uppdaterar spelets "interface" med nya siffror och namn
        {
            Console.Clear();                             // raderar alla tecken på skärmen
            Console.SetCursorPosition(0, 0);            // placerar pekaren i översta vänstra hörnet

            Console.WriteLine(" Player: Name: " + Player.Player_Name + " | ");  // skriver ut att det är spelaren stats som följer   
            Console.Write(" HP: " + Player.Player_HP.ToString() + " | ");       // Skriver ut spelarens hitpoints
            Console.Write(" Armor: " + Player.Player_Armor.ToString() + " | ");     // Skriver ut spelarens armor
            Console.Write(" AD: " + Player.Player_AD.ToString() + " | ");     // Skriver ut spelarens Attack damage

            //Skriver ut fiendens namn och stats
            Console.SetCursorPosition( 0, 3);
            Console.WriteLine (" Enemy: Name: " + Enemy.Name + " | ");       // skriver ut att det är fiendens stats som följer
            Console.Write(" HP: " + Enemy.HP.ToString() + " | ");      // skriver ut fiendens Hit points
            Console.Write(" Armor: " + Enemy.Armor.ToString() + " | ");      // skriver ut fiendens 
            Console.Write(" AD: " + Enemy.AD.ToString() + " | ");      // skriver ut fiendens attack damage
        }
    }
}
