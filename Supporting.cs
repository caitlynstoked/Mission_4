using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mission_4
{
    internal class Supporting
    {
        Program p = new Program();

        /*public string TicTacPrintV2(char board)
        { 
            Console.WriteLine(board);
        }*/
  
       /*StartCOmmentpublic string ChatTicTacPrint(char[,] board)
        {
            Console.WriteLine("This is the Tic Tac Toe Board:");

            string A = board[0, 0].ToString();
            string B = board[0, 1].ToString();
            string C = board[0, 2].ToString();
            string D = board[1, 0].ToString();
            string E = board[1, 1].ToString();
            string F = board[1, 2].ToString();
            string G = board[2, 0].ToString();
            string H = board[2, 1].ToString();
            string I = board[2, 2].ToString();

            string printBoard = $"{A} | {B} | {C}\n-+-+-\n{D} | {E} | {F}\n-+-+-\n{G} | {H} | {I}";

            Console.WriteLine(printBoard);

            return printBoard;
        }
       */

        public string TicTacPrint()//pass the array gathered from the driver team
        {
           // board = p.BoardPositions(); //calling from the program

            Console.WriteLine(" This is the Tic Tac Toe Board:");

            //1print current boad in a string
            string A = "X";
            string B = "0";
            string C = "0";
            string D = "0";
            string E = "0";
            string F = "0";
            string G = "0";
            string H = "0";
            string I = "0";

            string printBoard = $"{A} | {B} | {C}\n-+-+-\n{D} | {E} | {F}\n-+-+-\n{G} | {H} | {I}";

            Console.WriteLine(printBoard);

            return printBoard;



            //2then change the letters to Xs and Os deppending on positions. in an if if 2,2 then replace position to x

            //3return the board again and the guys will ask y to go 

        } 
        public string TicTacWin(Array board)
        {
            bool someoneWon = false;
            string nameOfWinner = "";


            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != ' ')
                    return board[i, 0];  // Winner in a row

                if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != ' ')
                    return board[0, i];  // Winner in a column
            }

           /* do
            {
                if ([a] (0,0) & (0,1) & (0,2))
                {
                    
                    
                }
                else
                {

                }

            } while (!someoneWon);

            return nameOfWinner
        }*/
        


    }
}
