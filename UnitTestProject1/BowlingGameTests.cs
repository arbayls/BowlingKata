using System;
using NUnit.Framework;

namespace Program
{
    [TestFixture]
    public class GameTest {
        Game game;

        [SetUp]
        public void SetUp() {
            game = new Game();
        }

        [TearDown]
        public void RemoveGame() {
            game = null;
        }

        [Test]
        public void GutterGame() {
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void OnePinGame() {
            for (int i=0;i<20;i++) {
                game.Throw(1);
            }
            Assert.AreEqual(20, game.Score());
        }

        [Test]
        public void SpareGame() {
            game.Throw(5);
            game.Throw(5); // spare
            game.Throw(2);
            Assert.AreEqual(14, game.Score());
        }

        [Test]
        public void StrikeGame()
        {
            game.Throw(10);
            game.Throw(1);
            game.Throw(6);
            Assert.AreEqual(24, game.Score());
        }

        [Test]
        public void PerfectGame()
        {
            for (int i = 0; i < 12; i++)
            {
                game.Throw(10);
            }
            Assert.AreEqual(300, game.Score());
        }
    }
}

