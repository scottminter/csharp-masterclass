
using Exercise9TicTacToeWinner;

string[,] board =
{
    {"1", "x", "3"},
    {"4", "x", "6"},
    {"7", "x", "9"}
};

var isWinner = TicTacToe.Checker(board);
if (isWinner)
{
    Console.WriteLine($"There is a winner");
}
else
{
    Console.WriteLine("There is NOT a winner");
}





Console.Read();