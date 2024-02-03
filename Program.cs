//this is proof of a git push/pull
using Mission_4;

Supporting s = new Supporting();

//s.TicTacPrint();

char[,] board = {
    {'X', 'O', 'X'},
    {' ', 'X', 'O'},
    {'X', 'O', ' '}
};


Console.WriteLine(s.CheckWinner(board));