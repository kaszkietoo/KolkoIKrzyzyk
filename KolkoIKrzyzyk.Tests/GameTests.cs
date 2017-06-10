using Microsoft.VisualStudio.TestTools.UnitTesting;
using KolkoIKrzyzyk.Engine;

namespace KolkoIKrzyzyk.Tests
{
    [TestClass]
    public class GameTests
    {
        private Game _game;

        [TestInitialize]
        public void Init()
        {
            _game = new Game(new Board());
        }

        [TestMethod]
        public void ShouldReturnBoardAfterFirstMove()
        {
            _game.Start();
            _game.Mark(0, 0);

            Assert.AreEqual(_game.CurrentPlayer.Kind, _game.Board[0, 0]);
        }
    }
}
