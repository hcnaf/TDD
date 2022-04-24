using HarryPotterShop;
using NUnit.Framework;
using System;

namespace HarryPotterShopTests
{
    public class HarryPotterShopTests
    {
        public void CalculateTotal_ArgumentIsNull_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => HarryPotterShop.HarryPotterShop.CalculateTotal(null));

        public void CalculateTotal_UnTypedBook_ThrowsArgumentException() =>
            Assert.Throws<ArgumentException>(() => HarryPotterShop.HarryPotterShop.CalculateTotal(new[] { new Book() }));

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.ValidTestCasesForCalculateTotal))]
        public void CalculateTotal_ValidArguments_ReturnsTotal(Book[] books, decimal result) =>
            Assert.AreEqual(result, HarryPotterShop.HarryPotterShop.CalculateTotal(books));
    }
}