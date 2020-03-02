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

    public string PrintBoard()
    {
      return $"\ny\n\n0 {Board[0][0]}|{Board[0][1]}|{Board[0][2]}\n  -----\n1 {Board[1][0]}|{Board[1][1]}|{Board[1][2]}\n  -----\n2 {Board[2][0]}|{Board[2][1]}|{Board[2][2]}\n\n  0 1 2 x";
    }

    public void IncrementTurn()
    {
      TurnCount++;
      ChangeCurrentPlayer();
    }

    public void ChangeCurrentPlayer()
    {
      if(TurnCount % 2 == 0)
      {
        CurrentPlayer = 'O';
      }
      else
      {
        CurrentPlayer = 'X';
      }
    }

    public bool PlayerMove(int x, int y)
    {
      if (Board[y][x] != 'X' && Board[y][x] != 'O')
      {
        Board[y][x] = CurrentPlayer;
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool CheckWin()
    {
      if(TurnCount >= 5)
      {
        if (
        Board[0][0] != ' ' && Board[0][0] == Board[1][0] && Board[1][0] == Board[2][0] || 
        Board[0][1] != ' ' && Board[0][1] == Board[1][1] && Board[1][1] == Board[2][1] || 
        Board[0][2] != ' ' && Board[0][2] == Board[1][2] && Board[1][2] == Board[2][2] || 
        Board[0][0] != ' ' && Board[0][0] == Board[0][1] && Board[0][1] == Board[0][2] || 
        Board[1][0] != ' ' && Board[1][0] == Board[1][1] && Board[1][1] == Board[1][2] || 
        Board[2][0] != ' ' && Board[2][0] == Board[2][1] && Board[2][1] == Board[2][2] || 
        Board[0][0] != ' ' && Board[0][0] == Board[1][1] && Board[1][1] == Board[2][2] || 
        Board[2][0] != ' ' && Board[2][0] == Board[1][1] && Board[1][1] == Board[0][2] )
        {
          return true;
        }
      }
      return false;
    }

    public bool CheckTie()
    {
      if (TurnCount == 9 && this.CheckWin() == false)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}