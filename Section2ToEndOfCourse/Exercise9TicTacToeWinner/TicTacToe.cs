using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9TicTacToeWinner
{
    public class TicTacToe
    {
        public static bool Checker(string[,] board)
        {
            bool isWinner = false;

            var winningRow = HorizontalChecker(board);
            Console.WriteLine($"winning row: {winningRow}");
            var winningColumn = VerticalChecker(board);
            Console.WriteLine($"winning col: {winningColumn}");
            var diagonalWinner = DiagonalChecker(board);
            Console.WriteLine($"diag winner: {diagonalWinner}");

            if (winningRow != null || winningColumn != null || diagonalWinner)
            {
                isWinner = true;
            }

            return isWinner;
        }

        private static bool DiagonalChecker(string[,] board)
        {
            var diagonalWinner = false;

            if (
                board[0, 0] == board[1, 1] &&
                board[1, 1] == board[2, 2] &&
                (board[0, 0] == "x" || board[0, 0] == "y") &&
                (board[1, 1] == "x" || board[1, 1] == "y") &&
                (board[2, 2] == "x" || board[2, 2] == "y")
                )
            {
                diagonalWinner = true;
            }
            else if (
                board[0, 2] == board[1, 1] &&
                board[1, 1] == board[2, 0] &&
                (board[0, 2] == "x" || board[0, 2] == "y") &&
                (board[1, 1] == "x" || board[1, 1] == "y") &&
                (board[2, 0] == "x" || board[2, 0] == "y")
                )
            {
                diagonalWinner = true;
            }

            return diagonalWinner;
        }

        private static int? VerticalChecker(string[,] board)
        {
            int? winnerColumn = null;

            for (var i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    winnerColumn = i;
                    break;
                }
            }

            return winnerColumn;
        }

        private static int? HorizontalChecker(string[,] board)
        {
            // if null is returned then no winner was found
            int? winnerRow = null;

            for (var i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    winnerRow = i;
                    break;
                }
            }

            return winnerRow;
        }
    }
}