using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToe.TestTools
{
  [TestClass]
  public class TicTacToeTests
  {
    [TestMethod]
    public void Game_IntsantiatesWithCorrectValues_Player()
    {
      Game newGame = new Game();
      Assert.AreEqual('X', newGame.CurrentPlayer);
    }
    
    [TestMethod]
    public void Game_IntsantiatesWithCorrectValues_TurnCount()
    {
      Game newGame = new Game();
      Assert.AreEqual(1, newGame.TurnCount);
    }
    
    [TestMethod]
    public void Game_IntsantiatesWithCorrectValues_Board0()
    {
      Game newGame = new Game();
      char[] BoardArr = {' ', ' ', ' '};
      CollectionAssert.AreEqual(BoardArr, newGame.Board[0]);
    }

    [TestMethod]
    public void PrintBoard_ConstructsBoardCorrectly_Board()
    {
      Game newGame = new Game();
      string newBoard = $" | | \n-----\n | | \n-----\n | | \n";
      Assert.AreEqual(newBoard, newGame.PrintBoard());
    }
    [TestMethod]
    public void IncrementTurn_Add1ToTurn_2()
    {
      Game newGame = new Game();
      newGame.IncrementTurn();
      Assert.AreEqual(2, newGame.TurnCount);
    }
  }
}