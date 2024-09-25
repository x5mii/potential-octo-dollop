using Microsoft.VisualStudio.TestTools.UnitTesting;
using potential_octo_dollop.Functions;

namespace potentialTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLegalReserveCalculation()
        {
            // Arrange
            var company = new Company(100000, 15000, 10000, 20000, 50000, 30000);
            var calc = new Calculation();

            // Act
            var legalReserve = calc.CalculateLegalReserve(company);

            // Assert
            Assert.AreEqual(2500, legalReserve); // Expected reserve based on the calculation
        }

        [TestMethod]
        public void TestAvailableProfitCalculation()
        {
            // Arrange
            var company = new Company(100000, 15000, 10000, 20000, 50000, 30000);
            var calc = new Calculation();
            var legalReserve = calc.CalculateLegalReserve(company);

            // Act
            var availableProfit = calc.CalculateAvailableProfit(company, legalReserve);

            // Assert
            Assert.AreEqual(57500, availableProfit); // Expected available profit
        }

        [TestMethod]
        public void TestDividendCalculation_WhenProfitIsSufficient()
        {
            // Arrange
            var company = new Company(100000, 15000, 10000, 20000, 50000, 30000);
            var calc = new Calculation();
            var legalReserve = calc.CalculateLegalReserve(company);
            var availableProfit = calc.CalculateAvailableProfit(company, legalReserve);

            // Act
            var dividend = calc.CalculateDividend(company, availableProfit);

            // Assert
            Assert.AreEqual(20000, dividend); // Desired dividend can be paid
        }

        [TestMethod]
        public void TestDividendCalculation_WhenProfitIsInsufficient()
        {
            // Arrange
            var company = new Company(100000, 15000, 10000, 20000, 10000, 30000); // Lower annual profit
            var calc = new Calculation();
            var legalReserve = calc.CalculateLegalReserve(company);
            var availableProfit = calc.CalculateAvailableProfit(company, legalReserve);

            // Act
            var dividend = calc.CalculateDividend(company, availableProfit);

            // Assert
            Assert.AreEqual(19500, dividend); // Only 19500 available for dividend
        }

        [TestMethod]
        public void TestNewProfitPresentation()
        {
            // Arrange
            var company = new Company(100000, 15000, 10000, 20000, 50000, 30000);
            var calc = new Calculation();
            var legalReserve = calc.CalculateLegalReserve(company);
            var availableProfit = calc.CalculateAvailableProfit(company, legalReserve);
            var dividend = calc.CalculateDividend(company, availableProfit);

            // Act
            var newProfitPresentation = calc.CalculateNewProfitPresentation(company, availableProfit, dividend);

            // Assert
            Assert.AreEqual(37500, newProfitPresentation); // Remaining profit after dividend
        }

        [TestMethod]
        public void TestInvalidInputs()
        {
            // Arrange
            var company = new Company(100000, 15000, 10000, -20000, -50000, 30000); // Invalid negative values
            var calc = new Calculation();

            // Act and Assert
            Assert.IsFalse(calc.IsInputValid(company)); // Validation should fail
        }
    }
}
