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
      char[] BoardArr = {'a', 'b', 'c'};
      CollectionAssert.AreEqual(BoardArr, newGame.Board[0]);
    }

    [TestMethod]
    public void PrintBoard_ConstructsBoardCorrectly_Board()
    {
      Game newGame = new Game();
      string newBoard = $"a|b|c\n-----\nd|e|f\n-----\ng|h|i\n";
      Assert.AreEqual(newBoard, newGame.PrintBoard());
    }
    
    [TestMethod]
    public void IncrementTurn_Add1ToTurn_2()
    {
      Game newGame = new Game();
      newGame.IncrementTurn();
      Assert.AreEqual(2, newGame.TurnCount);
    }
    
    [TestMethod]
    public void ChangeCurrentPlayer_ChangesToOAfter1Turn_O()
    {
      Game newGame = new Game();
      newGame.IncrementTurn();
      Assert.AreEqual('O', newGame.CurrentPlayer);
    }

    [TestMethod]
    public void PlayerMove_ChangesCoordinateToX_X()
    {
      Game newGame = new Game();
      char[] BoardArr = {'X', 'b', 'c'};
      newGame.PlayerMove(0,0);
      CollectionAssert.AreEqual(BoardArr, newGame.Board[0]);
    }
    
    [TestMethod]
    public void PlayerMove_ChecksForTakenSpace_false()
    {
      Game newGame = new Game();
      newGame.Board[0][0] = 'X';
      Assert.AreEqual(false, newGame.PlayerMove(0,0));
    }

    [TestMethod]
    public void CheckWin_ReturnsTrueForWin_true()
    {
      Game newGame = new Game();
      newGame.TurnCount = 6;
      newGame.Board[0][0] = 'O';
      newGame.Board[1][0] = 'O';
      newGame.Board[2][0] = 'O';
      Assert.AreEqual(true, newGame.CheckWin());
    }

    [TestMethod]
    public void CheckTie_ReturnsTrueOnTie_true()
    {
      Game newGame = new Game();
      newGame.TurnCount = 9;
      Assert.AreEqual(true, newGame.CheckTie());
    }
  }
}