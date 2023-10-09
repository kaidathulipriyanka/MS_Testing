using ShopKeeper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ShopkeeperTests
{
    [TestClass]
    public class PurchaseAnalyzerTests
    {
        [TestMethod]
        public void TestFindPriceOfItemSoldOnce()
        {
            int[] purchases = { 5, 5, 4, 7, 4, 1, 11 };
            int expected = 7;
            int result = PurchaseAnalyzer.FindPriceOfItemSoldOnce(purchases);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestFindPriceOfItemSoldMoreThanOnce()
        {
            int[] purchases = { 5, 5, 4, 7, 4, 1, 11 };
            int expected = 5;
            int result = PurchaseAnalyzer.FindPriceOfItemSoldMoreThanOnce(purchases);
            Assert.AreEqual(expected, result);
        }
    }
}