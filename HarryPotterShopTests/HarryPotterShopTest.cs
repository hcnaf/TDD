using HarryPotterShop;
using NUnit.Framework;
using System;

namespace HarryPotterShop.Tests
{
    public class HarryPotterShopTests
    {
        [Test]
        public void CalculateTotal_ArgumentIsNull_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => HarryPotterShop.CalculateTotal(null));

        [Test]
        public void CalculateTotal_UnTypedBook_ThrowsArgumentException() =>
            Assert.Throws<ArgumentException>(() => HarryPotterShop.CalculateTotal(new[] { new Book() }));

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.ValidTestCasesForCalculateTotal))]
        public void CalculateTotal_ValidArguments_ReturnsTotal(Book[] books, decimal result) =>
            Assert.AreEqual(result, HarryPotterShop.CalculateTotal(books));
    }
}