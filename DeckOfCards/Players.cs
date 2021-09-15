using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Players
    {
        public void Suffel()
        {
            string[] cards = { "C-Ace","C-2","C-3", "C-4", "C-5", "C-6", "C-7", "C-8", "C-9", "C-10", "C-Jack", "C-Queen", "C-King",
                               "D-Ace","D-2","D-3", "D-4", "D-5", "D-6", "D-7", "D-8", "D-9", "D-10", "D-Jack", "D-Queen", "D-King",
                               "H-Ace","H-2","H-3", "H-4", "H-5", "H-6", "H-7", "H-8", "H-9", "H-10", "H-Jack", "H-Queen", "H-King",
                               "S-Ace","S-2","S-3", "S-4", "S-5", "S-6", "S-7", "S-8", "S-9", "S-10", "S-Jack", "S-Queen", "S-King"};
            string[,] players = new string[4, 9];
            Random random = new Random();

            int[] duplicate = new int[80];
            int[] original = new int[50];

            for (int i = 0; i < duplicate.Length; i++)
            {
                int num = random.Next(0, 52);
                duplicate[i] = num;
                //Console.Write(" " + duplicate[i]);
            }

            int z = 0;
            for (int i = 0; i < duplicate.Length; i++)
            {
                int count = 1;
                for (int k = 0; k < i; k++)
                {
                    if (duplicate[i] == duplicate[k])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    original[z] = duplicate[i];
                    z++;
                }
            }
            Console.WriteLine();
            int x = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    players[i, j] = cards[original[x]];
                    x++;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Player{0} : ", i);
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(players[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
