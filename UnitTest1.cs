using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PurchaseAnalyzerTest
{
    [TestClass]
    public class PurchaseAnalyzerTests
    {
        [TestMethod]
        public void GetPriceOfItemSoldOnce_WithValidInput_ReturnsCorrectPrice()
        {
            // Arrange
            string purchases = "5 5 4 7 4 1 11";
            int expectedPrice = 7;
            var analyzer = new PurchaseAnalyzer();

            // Act
            int actualPrice = analyzer.GetPriceOfItemSoldOnce(purchases);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void GetPriceOfItemSoldOnce_WithNoUniquePurchases_ReturnsNone()
        {
            // Arrange
            string purchases = "5 5 5 5";
            int expectedPrice = 0; // Assuming 0 indicates "none"
            var analyzer = new PurchaseAnalyzer();

            // Act
            int actualPrice = analyzer.GetPriceOfItemSoldOnce(purchases);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void GetPriceOfItemSoldMoreThanOnce_WithValidInput_ReturnsCorrectPrice()
        {
            // Arrange
            string purchases = "5 5 4 7 4 1 11";
            int expectedPrice = 5;
            var analyzer = new PurchaseAnalyzer();

            // Act
            int actualPrice = analyzer.GetPriceOfItemSoldMoreThanOnce(purchases);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void GetPriceOfItemSoldMoreThanOnce_WithNoRepeatedPurchases_ReturnsNone()
        {
            // Arrange
            string purchases = "1 2 3 4 5";
            int expectedPrice = 0; // Assuming 0 indicates "none"
            var analyzer = new PurchaseAnalyzer();

            // Act
            int actualPrice = analyzer.GetPriceOfItemSoldMoreThanOnce(purchases);

            // Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }

}

