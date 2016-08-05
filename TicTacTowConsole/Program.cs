using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TikTacTowConsole;

namespace TicTacTowConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Grid  x = new  Grid();

            bool winner = false;

            Random rand = new Random();
            int xCord = 0;
            int yCord = 0;
            
            while (winner == false)
            {
                xCord = rand.Next(0, 3);
                yCord = rand.Next(0, 3);
                Console.WriteLine(xCord + ' ' + yCord);
                if (x.CheckIfAvailable(xCord, yCord) == true)
                {
                    if (x.PlacePiece(Grid.player.x, xCord, yCord) == true)
                    {
                        winner = true;
                        Console.Write("Winner");
                    }
                }
            }
        }
    }
}
