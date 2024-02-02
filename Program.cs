// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to tic tac toe!");

string position1 = "";
string position2 = "";
List<string> board = new List<string>();
Boolean winner = false;

do 
{
    Console.WriteLine("Horizontal (0-2)");
    position1 = Console.ReadLine();

    Console.WriteLine("Vertical (0-2)");
    position2 = Console.ReadLine();

    string PlayerChoice = position1 + ", " + position2;

    board.Add(PlayerChoice); 
} while (winner = false);







