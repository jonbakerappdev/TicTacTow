using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TikTacTowConsole
{
    public class Grid
    {
        public enum player { blank, x, o };
        player[,] grid = new player[3, 3];

        public void New()
        {
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            int x = 0;
            int y = 0;

            while (x < 3)
            {
                while (y < 3)
                {
                    grid[x, y] = player.blank;
                }
            }
        }

        public Boolean PlacePiece(player player, int r, int c)
        {
            grid[r, c] = player;
            return CheckIfWinner(player);
        }

        public bool CheckIfAvailable(int row, int column)
        {
            if (grid[row, column] == player.blank)
            {
                return true;
            }

            return false;
        }

        private bool CheckIfWinner(player person)
        {
            if (CheckRows(person) == true || CheckColumns(person) == true || CheckDiagnals(person) == true)
            {
                return true;
            }
            return false;
        }

        private bool CheckDiagnals(player person)
        {
            if (grid[0, 0] == person && grid[1, 1] == person && grid[2, 2] == person)
            {
                return true;
            }
            if (grid[2, 0] == person && grid[1, 1] == person && grid[0, 2] == person)
            {
                return true;
            }
            return false;
        }

        private bool CheckColumns(player person)
        {
            bool winner = false;
            int y = 0;
            while (winner != true && y < 3)
            {
                if (grid[0, y] == person && grid[1, y] == person && grid[2, y] == person)
                {
                    winner = true;
                }
                y++;
            }
            return winner;
        }

        private bool CheckRows(player person)
        {
            bool winner = false;
            int x = 0;

            while (winner != true && x < 3)
            {
                if (grid[x, 0] == person && grid[x, 1] == person && grid[x, 2] == person)
                {
                    winner = true;
                }
                x++;
            }
            return winner;
        }
    }
}
