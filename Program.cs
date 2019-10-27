﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Calculate_Batting_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
Project:    Lab 2 Calculate Batting Average
Date:        to/da/y
Author:     You the big new programmer
Notes:      This program reads in a baseball player's name,
            number of hits and number of at bats.
            The player's batting average is calculated and displayed
*/

            //variable declaration
            string strPlayerName;
            double dblHits, dblAtBats;
            double dblBattingAverage;
            //prompt for name and recieve
            Console.WriteLine("~This program calculates a baseball player's batting average~");
            Console.WriteLine("<----------------------------------------------------------->");
            Console.WriteLine("");//we will learn other ways to do this in console programs
            Console.WriteLine("Enter the player's name: ");
            strPlayerName = Console.ReadLine();

            //prompt for hits, walks and at bats
            Console.WriteLine("Enter the player's # of hits: ");
            dblHits = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the player's # of at bats: ");
            dblAtBats = Convert.ToInt32(Console.ReadLine());

            //calculation
            dblBattingAverage = dblHits / dblAtBats;

            Console.WriteLine(strPlayerName + "'s Batting average is " + dblBattingAverage);
            Console.ReadLine();


        }
    }
}

