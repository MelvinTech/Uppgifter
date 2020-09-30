using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Final_Project
{
    class Game_Room
    {
        int Nr_Paths;
        public Game_Room()
        {
            Random Room_gen = new Random();
            Nr_Paths = Room_gen.Next(0, 4);

            if ( Nr_Paths.Equals(1))
            {

            }
            if (Nr_Paths.Equals(2))
            {

            }
            if (Nr_Paths.Equals(3))
            {

            }
        }
        
    }
}
