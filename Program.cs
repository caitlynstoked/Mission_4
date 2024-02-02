// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;


Console.WriteLine("Welcome to tic tac toe!\n");

int position1 = 0;
int position2 = 0;
string sign = "";
int turns = 1;
List<string> board = new List<string>();
List<string> chosenPositions = new List<string>(); // Keep track of chosen positions
Boolean winner = false; //this will be set equal to the check for win function
string playerChoice = "";
string playerName = "";

do 
{
    //assign a variable to the correct player
    if (turns % 2 == 1)
    {
        sign = "X";
        playerName = "player 1";
    }
    else
    {
        sign = "O";
        playerName = "player 2";
    }


    // gather valid user inputs
    do
    {
        Console.Write($"Please enter an X value {playerName} (0-2): ");
        if (!int.TryParse(Console.ReadLine(), out position1) || position1 < 0 || position1 > 2)
        {
            Console.WriteLine("Please enter a valid numeric value between 0 and 2.");
        }
    } while (position1 < 0 || position1 > 2);

    do
    {
        Console.Write($"Please enter a Y value {playerName} (0-2): ");
        if (!int.TryParse(Console.ReadLine(), out position2) || position2 < 0 || position2 > 2)
        {
            Console.WriteLine("Please enter a valid numeric value between 0 and 2.");
        }
    } while (position2 < 0 || position2 > 2);

    playerChoice = position1 + ", " + position2;

    // check to make sure that there are no repeats
    while (chosenPositions.Contains(playerChoice))
    {
        Console.WriteLine("Error: Position already chosen. Please choose a new position.");

        // Ask for new coordinates
        do
        {
            Console.Write($"Please enter an X value {playerName} (0-2): ");
            if (!int.TryParse(Console.ReadLine(), out position1) || position1 < 0 || position1 > 2)
            {
                Console.WriteLine("Please enter a valid numeric value between 0 and 2.");
            }
        } while (position1 < 0 || position1 > 2);

        do
        {
            Console.Write($"Please enter a Y {playerName} value (0-2): ");
            if (!int.TryParse(Console.ReadLine(), out position2) || position2 < 0 || position2 > 2)
            {
                Console.WriteLine("Please enter a valid numeric value between 0 and 2.");
            }
        } while (position2 < 0 || position2 > 2);

        playerChoice = position1 + ", " + position2;
    }



    chosenPositions.Add(playerChoice);
    board.Add(playerChoice);

    foreach (string boardTurns in board)
    {
        Console.WriteLine(boardTurns);

    }

    // call the print board function
    turns++;
    if (turns == 9)
    {
        Console.WriteLine("\nThe board is full!\nGood game, there is no winner.");
        return;
    }


    Console.WriteLine(sign);
} while (winner == false);



//char[,] board = new char[3, 3];














//new value = sign
//prints out board
;







