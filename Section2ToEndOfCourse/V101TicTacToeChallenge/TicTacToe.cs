using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V101TicTacToeChallenge
{
    public class TicTacToe
    {
        private string[,] board =
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
        };

        private int playerToPlay = 1;
        private int turnsTaken = 0;

        public TicTacToe()
        {
            Console.WriteLine("Player 1 = X and Player 2 = Y\n");
        }

        public void PlayGame()
        {
            bool isWinner = false;
            while (turnsTaken < 9)
            {
                DisplayBoard();
                GetTurn();
                isWinner = IsWinner();

                if (isWinner)
                {
                    break;
                }
                else
                {
                    playerToPlay = playerToPlay == 1 ? 2 : 1;
                }
            }

            DisplayBoard();

            if (isWinner)
            {
                Console.WriteLine($"Player {playerToPlay} has won!");
            }
            else
            {
                Console.WriteLine("Game Over. Draw!");
            }
        }

        public void GetTurn()
        {
            Console.Write($"Player {playerToPlay} choose your move: ");
            string boardPosition = Console.ReadLine();
            Console.WriteLine($"Player {playerToPlay} has chosen {boardPosition}");

            if (boardPosition != null && boardPosition != string.Empty)
            {
                UpdateBoard(playerToPlay, boardPosition);
            }
        }

        public void DisplayBoard()
        {
            Console.Clear();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.WriteLine("   |   |   ");
                Console.WriteLine($" {board[i, 0]} | {board[i, 1]} | {board[i, 2]} ");
                
                if (i == board.GetLength(1) - 1)
                {
                    Console.WriteLine("   |   |   ");
                }
                else
                {
                    Console.WriteLine("___|___|___");
                }
            }
            
        }

        private void UpdateBoard(int player, string position)
        {
            string charToPlay = player == 1 ? "x" : "y";

            for (var i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == position)
                    {
                        board[i, j] = charToPlay;
                        turnsTaken++;

                        break;
                    }
                }
            }
        }

        private bool IsWinner()
        {
            bool isWinner = false;

            var diagonalWinner = DiagonalChecker(board);
            var verticalWinner = VerticalChecker(board);
            var horizontalWinner = HorizontalChecker(board);

            if (horizontalWinner != null || verticalWinner != null || diagonalWinner)
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
