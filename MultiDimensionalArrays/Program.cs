using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    class Program
    {
        static int maxPlayers = 4;
        static int[] score = new int[maxPlayers]; // score for each player
        static int[] x = new int[maxPlayers];
        static int[] y = new int[maxPlayers];
        static int[] weapon = new int[maxPlayers];
        static bool[] alive; // alive or dead in game
        static bool[] active;
        static int player;

        static void Main(string[] args)
        {
            Console.WriteLine("Variables RECAP");
            Console.WriteLine();

            ShowHUD();

            Console.WriteLine("1D arrays RECAP");
            Console.WriteLine();

            // we want to do 4x multiplayer
            // (Should know how to do this at this point)
            // int maxPlayers = 4;
            // int[] score = new int[maxPlayers]; // score for each player
            // int[] x = new int[maxPlayers];
            // int[] y = new int[maxPlayers];
             //int[] weapon = new int[maxPlayers];
            
            //init. scores to 0
            //init player locations (to somewhere)
            //init player weapons to 0 (1st weapon)
            // ???
            //(Should know how to do this at this point!)
            
            // is there a better way??? A LOOP!!!

            //init player data
            for (int player = 0; player < maxPlayers; player++) // 3 because arrays start at 0 (for a total of 4)
            {
                //init scores to 0
                score[player] = 0;

                //init player weapons to 0 = 1st (default) weapon
                weapon[player] = 0; // 0 = 1st (default) weapon

                x[player] = 0;
                y[player] = 0;
            }

            Console.WriteLine("Multi Dimensional Arrays");
            Console.WriteLine();
            Console.ReadKey(true);
            
        }

        static void ShowHUD()
        {
            for(int player = 0; player < maxPlayers; player++)
                
                //putting player + 1 in () forces it to go first
            Console.WriteLine("Player #" + (player + 1) + " Score: " + score[player]);
            Console.WriteLine("- Score: " + score[player]);
            Console.WriteLine("- Weapon: " + weapon[player]);
            Console.WriteLine("- Location: (" + x[player] + "," + y[player] + ")");
            //Console.WriteLine();
            // int + int = int
            // str + str = str (concatenation of strings--> "2" + "2" = "22")
            // str + int = str (concatenation of strings--> "2" + "2" = "22")

        }
    }
}
