using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JunkDemos;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Scorecard scorcard = new Scorecard();
            scorcard.Add("player1", 10);
            scorcard.Add("player2", 15);

            int expectedScore = 15;
            int actualScore = scorcard["player2"];
            Assert.AreEqual(expectedScore, actualScore);

        }
    }
}
