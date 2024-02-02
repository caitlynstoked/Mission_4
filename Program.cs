// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

int postion1 = 0;
int postion2 = 0;
string sign = "";
int turns = 1;

Console.WriteLine("Welcome to tic tac toe!");

int position1 = 0;
int position2 = 0;
List<string> board = new List<string>();
Boolean winner = false; //this will be set equal to the check for win function

do 
{
    if (turns % 2 == 1)
    {
        sign = "X";
    }
    else
    {
        sign = "0"; 
    }



    do
    {
        Console.Write("Horizontal (0-2):");
    } while (!int.TryParse(Console.ReadLine(), out position1) || position1 < 0 || position1 > 2);

    do
    {
        Console.Write("Vertical (0-2):");
    } while (!int.TryParse(Console.ReadLine(), out position2) || position2 < 0 || position2 > 2);
  




    string PlayerChoice = position1 + ", " + position2;

    board.Add(PlayerChoice);

    // call the print board function
    turns++;
    if (turns == 9)
    {
        Console.WriteLine("\nThe board is full!\nGood game, there is no winner.");
        return;
    }


    Console.WriteLine(sign);
} while (winner = false);



//char[,] board = new char[3, 3];














//new value = sign
//prints out board
;







