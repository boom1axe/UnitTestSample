using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestingExample.Models;

namespace TestingExampleTests.Models.Tests
{
    [TestClass()]
    public class TestingExample
    {
        [TestMethod]
        [DataRow(0)]
        [DataRow(300)]
        public void SetGame1_ValidScore_SetsValue()
        {
            SimpleGame g = new SimpleGame();

            g.Game1 = initialScore;

            Assert.AreEqual(initialScore, g.Game1);
        }

        [TestMethod]
        [DataRow(301)]
        public void SetGame1_InvalidScore_ThrowsArgumentOutOfRangeException(int? score)
        {
            var g = new SimpleGame();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => g.Game1 = score);
        }

        [TestMethod]
        public void TotalScore_ReturnsSumOfAllGames()
        {
            var g = new SimpleGame();

            Assert.AreEqual(0, g.TotalScore);
            g.Game1 = 250;
            g.Game2 = 125;

            Assert.AreEqual(375, g.TotalScore);
        }

    }

}
