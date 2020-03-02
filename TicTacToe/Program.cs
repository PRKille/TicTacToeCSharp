using System;
using System.Collections.Generic;
using TicTacToe;

public class Program
{
  public static Game newGame = new Game();
  public static void Main()
  {
    Console.WriteLine("Welcome to TicTacToe!\nPlayer X Goes first.\nPlease input the coordinates you would like to play on:");
    GameLoop();

  }
  public static void GameLoop()
  {
    Console.WriteLine(newGame.PrintBoard());
    Console.Write($"{newGame.CurrentPlayer}: Please enter your X Coordinate: ");
    int playerXMove = int.Parse(Console.ReadLine());
    Console.Write($"{newGame.CurrentPlayer}: Please enter your Y Coordinate: ");
    int playerYMove = int.Parse(Console.ReadLine());
    bool moveBool = newGame.PlayerMove(playerXMove, playerYMove);
    if(!moveBool)
    {
      Console.WriteLine("That space is already taken!");
      GameLoop();
    }
    else
    {
      if(newGame.CheckWin())
      {
        Console.WriteLine(newGame.PrintBoard());
        Console.WriteLine($"\nPlayer {newGame.CurrentPlayer} Wins!\n");
      }
      else if(newGame.CheckTie())
      {
        Console.WriteLine(newGame.PrintBoard());
        Console.WriteLine("\nIt's a Tie!\n");
      }
      else
      {
        newGame.IncrementTurn();
        newGame.ChangeCurrentPlayer();
        GameLoop();
      }
    }
  }
}