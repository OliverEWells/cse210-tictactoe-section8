
using System;
using System.Collections.Generic;

namespace Board_using;

class TicTacToe
{
    static void Main(string[] args)
    {

        Board board = new Board();
        board.make_board();
    
        string currentPlayer = "x";

        while (!IsGameOver(board.board))
        {
            DisplayBoard(board.board);

            int choice = GetMoveChoice(currentPlayer);
            MakeMove(board.board, choice, currentPlayer);

            currentPlayer = GetNextPlayer(currentPlayer);
        }

        board.print();
        Console.WriteLine("Good game. Thanks for playing!");
    }

    /// <summary>Gets a new instance of the board with the numbers 1-9 in place. </summary>
    /// <returns>A list of 9 strings representing each square.</returns>

    /// <summary>Displays the board in a 3x3 grid.</summary>
    /// <param name="board">The board</param>
    static void DisplayBoard(List<string> board)
    {
        //void means returns nothing
        Console.WriteLine($"{board[0]}│{board[1]}│{board[2]}\n──┼──┼── \n{board[3]}│{board[4]}│{board[5]}\n──┼──┼── \n{board[6]}│{board[7]}│{board[8]}");
    }

    /// <summary>
    /// Determines if the game is over because of a win or a tie.
    /// </summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the game is over</returns>
    static bool IsGameOver(List<string> board)
    {
        // "||" is an OR boolean function.
        // Oh, bool means it wants to return a boolean value
        return IsWinner(board, "x") || IsWinner(board, "o") || IsTie(board);
    }

    /// <summary>Determines if the provided player has a tic tac toe.</summary>
    /// <param name="board">The current board</param>
    /// <param name="player">The player to check for a win</param>
    /// <returns></returns>
    static bool IsWinner(List<string> board, string player)
    {
        if ((board[0]== player && board[1] == player && board[2] == player) 
        || (board[3]== player && board[4] == player && board[5] == player)
        || (board[6]== player && board[7] == player && board[8] == player)
        || (board[0]== player && board[3] == player && board[6] == player)
        || (board[1]== player && board[4] == player && board[7] == player)
        || (board[3]== player && board[5] == player && board[8] == player)
        || (board[0]== player && board[4] == player && board[8] == player)
        || (board[6]== player && board[4] == player && board[2] == player))
        {
            return true;
        }



        return false;
    }

    /// <summary>Determines if the board is full with no more moves possible.</summary>
    /// <param name="board">The current board.</param>
    /// <returns>True if the board is full.</returns>
    static bool IsTie(List<string> board)
    {


        foreach (string i in board) {
            if (i.All(char.IsDigit)) 
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>Cycles through the players (from x to o and o to x)</summary>
    /// <param name="currentPlayer">The current players sign (x or o)</param>
    /// <returns>The next players sign (x or o)</returns>
    static string GetNextPlayer(string currentPlayer)
    {
        string nextPlayer = "x";

        if (currentPlayer == "x")
        {
            nextPlayer = "o";
        }


        return nextPlayer;
    }

    /// <summary>Gets the 1-based spot number associated with the user's choice.</summary>
    /// <param name="currentPlayer">The sign (x or o) of the current player.</param>
    /// <returns>A 1-based spot number (not a 0-based index)</returns>
    static int GetMoveChoice(string currentPlayer)
    {
        
        Console.Write($"{currentPlayer}'s turn to choose a square (1-9): ");
        string? move_string = Console.ReadLine() ?? "";
        // add the ?? ""; at the end to say if it gives you a null, use "" instead.

        if (move_string is null) {
            return 0;
        }
        
        int choice = int.Parse(move_string);
        return choice;
    }

    /// <summary>
    /// Places the current players mark on the board at the desired spot.
    /// This method does NOT check to ensure the spot is available.
    /// </summary>
    /// <param name="board">The current board</param>
    /// <param name="choice">The 1-based spot number (not a 0-based index).</param>
    /// <param name="currentPlayer">The current player's sign (x or o)</param>
    static void MakeMove(List<string> board, int choice, string currentPlayer)
    {
        int index = choice - 1;

        board[index] = currentPlayer;
    }
}
