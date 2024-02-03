// See https://aka.ms/new-console-template for more information

//Tic Tac Toe Assignment

// team 2-8
// Cristian Cruz, Caitlyn Stokes, Perla Valdovinos, Asante Laryea-Akrong
using Mission_4;
using System.Reflection.Metadata;
Supporting s = new Supporting();

//welcome user to the game
Console.WriteLine("Welcome to tic tac toe!\n");
Console.WriteLine("Enter the first value for the vertical axis and the second value for the horizontal axis.\nThe values range from 0 to 2.\nGood luck!!\n");
// defined variables
int position1 = 0;
int position2 = 0;
string sign = "";
int turns = 1;
List<string> board = new List<string>();
List<string> chosenPositions = new List<string>(); // Keep track of chosen positions
string playerChoice = "";
string playerName = "";
char[,] boardArray = {
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' }
        };


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


    //update the player choice array
    chosenPositions.Add(playerChoice);
    board.Add(playerChoice);

    //if they run out of turns then alert the users and end the game
    turns++;
    if (turns == 10)
    {
        Console.WriteLine("\nThe board is full!\nGood game, there is no winner.");
        s.DefineMoves(boardArray, board, sign);
        s.PrintTicTacToe(boardArray);
        return;
    }

    
    Console.WriteLine(" ");
    //call the supporting class functions to print the board
    s.DefineMoves(boardArray, board, sign);
    s.PrintTicTacToe(boardArray);
    
} while (s.CheckWinner(boardArray) == false);

//thank you message
Console.WriteLine("\nThanks for playing!!!!");