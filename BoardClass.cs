using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mission_4

{
    
    internal class BoardClass
    {
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
    }
}
