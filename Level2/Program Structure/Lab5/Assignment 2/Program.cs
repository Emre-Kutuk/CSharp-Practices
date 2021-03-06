﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CandyCrushLogic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myprogram = new Program();
            myprogram.Start();
        }

        void Start()
        {
            RegularCandies[,] candies = new RegularCandies[5, 5];
            string filename = "playingField.txt";

            if (!File.Exists(filename))
                WritePlayingField(candies, filename);
            else
                DisplayScore(CandyCrushLogic.CandyCrusher.ScoreRowPresent(ReadPlayingField(filename)), CandyCrushLogic.CandyCrusher.ScoreColomnPresent(ReadPlayingField(filename)));

            Console.ReadKey();
        }

       

        void DisplayScore(bool row, bool colomn)
        {
            if (row)
                Console.WriteLine("row score!");
            else
                Console.WriteLine("no row score!");
            if (colomn)
                Console.WriteLine("colomn score!");
            else
                Console.WriteLine("no colomn score!");
        }

        void WritePlayingField(RegularCandies[,] playingField, string filename)
        {
            Random rnd = new Random();
            StreamWriter writer = new StreamWriter(filename);
            int row;
            int colomn;
            writer.WriteLine(playingField.GetLength(0));
            writer.WriteLine(playingField.GetLength(1));

            for (row = 0; row < playingField.GetLength(0); row++)
            {
                List<int> candyvalues = new List<int>();
                for (colomn = 0; colomn < playingField.GetLength(1); colomn++)
                {
                    int value = rnd.Next(1, 7);
                    RegularCandies candyvalue = (RegularCandies)value;
                    playingField[row, colomn] = candyvalue;
                    candyvalues.Add(value);
                    writer.Write(value + " ");
                }

                writer.WriteLine();

            }

            writer.Close();
        }

        RegularCandies[,] ReadPlayingField(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            int rowfirst = int.Parse(reader.ReadLine());
            int colomnfirst = int.Parse(reader.ReadLine());
            RegularCandies[,] candies = new RegularCandies[rowfirst, colomnfirst];

            while (!reader.EndOfStream)
            {
                for (int row = 0; row < candies.GetLength(0); row++)
                {
                    string[] temp = reader.ReadLine().Split(' ');

                    for (int colomn = 0; colomn < candies.GetLength(1); colomn++)
                    {
                        int value = int.Parse(temp[colomn]);
                        candies[row, colomn] = (RegularCandies)value;
                    }
                }
            }
            return candies;
        }
    }
    }
