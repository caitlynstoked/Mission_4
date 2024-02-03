using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

//Tic Tac Toe Assignment

// team 2-8
// Cristian Cruz, Caitlyn Stokes, Perla Valdovinos, Asante Laryea-Akrong

namespace Mission_4
{
    internal class Supporting
    {

        //this function is what defines the coordinates for the print board function
        public void DefineMoves(char[,] board, List<string> moves, string sign)
        {

            int latestEnteredIndex = moves.Count - 1;

            foreach (var move in moves)
            {
                if (moves.IndexOf(move) == latestEnteredIndex)
                {
                    {
                        //Parse coordinates from the string
                        int row = int.Parse(move[0].ToString());
                        int col = int.Parse(move[3].ToString());

                        if (sign == "X")
                        {
                            board[row, col] = 'X';
                        }
                        else
                        {
                            board[row, col] = '0';
                        }
                    }
                }
            }
        }


        // this function prints the board with the current player choices
        public void PrintTicTacToe(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    if (col < 2)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine();
                if (row < 2)
                {
                    Console.WriteLine("---------");
                }
            }
        }



        //this function checks for the winner if there is one
        public bool CheckWinner(char[,] board)
        {
            bool isWinner = false;
            string whoWon = "";

            for (int i = 0; i < 3; i++)
            {
                // winner check in a row
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                {
                    isWinner = true;
                    whoWon = board[i, 0].ToString();
                }

                // winner check for column
                else if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                {
                    isWinner = true;
                    whoWon = board[0, i].ToString();

                }

                // check for diagonal
                else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
                {
                    isWinner = true;
                    whoWon = board[0, 0].ToString();

                }

                else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
                {
                    isWinner = true;
                    whoWon = board[0, 2].ToString();

                }

            }
            //prints who won 
            if (isWinner == true)
            {
                Console.WriteLine($"The Winner is: {whoWon}!!");
            }
            else if (isWinner == false)
            {
                Console.WriteLine("\nThere is no winner, try again!");
            }

            //return the winner
            return isWinner;

        }
    }
}

