using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PurchaseAnalyzerTest
{
public class GroupEligibilityCheckerTests
{
    [TestMethod]
    public void IsGroupEligible_WithEligibleWords_ReturnsTrue()
    {
        // Arrange
        string word1 = "noon";
        string word2 = "moon";
        bool expected = false;
        var checker = new GroupEligibilityChecker();

        // Act
        bool actual = checker.IsGroupEligible(word1, word2);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IsGroupEligible_WithIneligibleWords_ReturnsFalse()
    {
        // Arrange
        string word1 = "part";
        string word2 = "trap";
        bool expected = true;
        var checker = new GroupEligibilityChecker();

        // Act
        bool actual = checker.IsGroupEligible(word1, word2);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
}

