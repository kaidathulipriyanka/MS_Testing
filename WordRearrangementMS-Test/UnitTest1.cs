using Microsoft.VisualStudio.TestTools.UnitTesting;
 using WordRearrangement;
using System;
namespace WordRearrangementMS_Test
{
    [TestClass]
    public class WordRearrangementTests
    {
        [TestMethod]
        public void TestCheckEligibilityForNextRound_No()
        {
            string word1 = "noon";
            string word2 = "moon";
            string expected = "No";
            string result = Program.CheckEligibilityForNextRound(word1, word2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCheckEligibilityForNextRound_YES()
        {
            string word1 = "part";
            string word2 = "trap";
            string expected = "YES";
            string result = Program.CheckEligibilityForNextRound(word1, word2);
            Assert.AreEqual(expected, result);
        }
    }
}