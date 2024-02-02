// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

int postion1 = 0;
int postion2 = 0;
string sign = "";
int turns = 1;

Console.WriteLine("Welcome to tic tac toe!");

string position1 = "";
string position2 = "";
List<string> board = new List<string>();
Boolean winner = false;

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

    Console.WriteLine("Horizontal (0-2)");
    position1 = Console.ReadLine();

    Console.WriteLine("Vertical (0-2)");
    position2 = Console.ReadLine();

    string PlayerChoice = position1 + ", " + position2;

    board.Add(PlayerChoice);


    turns++;
} while (winner = false);



//char[,] board = new char[3, 3];














//new value = sign
//prints out board
;







