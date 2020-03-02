using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe;

namespace TicTacToe.TestTools
{
  [TestClass]
  public class TicTacToeTests
  {
    [TestMethod]
    public void Game_IntsantiatesWithCorrectValues_Game()
    {
      Game newGame = new Game();
      Assert.AreEqual('O', newGame.CurrentPlayer);
    }
  }
}