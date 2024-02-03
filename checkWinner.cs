using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_4
{
    internal class checkWinner
    {
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
                Console.WriteLine("There is no winner, try again!");
            }

            return isWinner;

        }
    }
}

