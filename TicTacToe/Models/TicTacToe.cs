using System;
using System.Collections.Generic;

namespace TicTacToe
{
  public class Game
  {
    public char CurrentPlayer {get;set;}
    public int TurnCount {get;set;}
    public char[][] Board {get;set;} = new char[3][];

    public Game()
    {
      CurrentPlayer = 'X';
      TurnCount = 1;
      Board[0] = new char[] {' ', ' ', ' '};
      Board[1] = new char[] {' ', ' ', ' '};
      Board[2] = new char[] {' ', ' ', ' '};
    }
  }
}