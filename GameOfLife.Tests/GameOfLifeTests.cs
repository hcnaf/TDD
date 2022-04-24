using NUnit.Framework;
using System;

namespace GameOfLife.Tests
{
    public class GameOfLifeTests
    {
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(int.MinValue)]
        public void Ctor_InvalidNumberOfRows_ThrowsArgumentOutOfRangeException(int rows) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => new GameOfLife(rows, 1, (0, 1)));

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(-10)]
        [TestCase(int.MinValue)]
        public void Ctor_InvalidNumberOfColumns_ThrowsArgumentOutOfRangeException(int columns) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => new GameOfLife(1, columns));

        [Test]
        public void Ctor_NullParams_ThrowsArgumentNullException() =>
            Assert.Throws<ArgumentNullException>(() => new GameOfLife(1, 1, null));


        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForInvalidLifeCell))]
        public void Ctor_InvalidLifeCell_ThrowsArgumentOutOfRangeException(int rows, int columns, (int row, int column)[] lifeCells) =>
            Assert.Throws<ArgumentOutOfRangeException>(() => new GameOfLife(rows, columns, lifeCells));

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForRenderInitial_Int))]
        public void Render_RenderInitial_ReturnsRenderedField_Int(int rows, int columns, int lifeCell, int deadCell, int[][] result, (int row, int column)[] lifeCells) =>
            Assert.AreEqual(result, new GameOfLife(rows, columns, lifeCells).Render(lifeCell, deadCell));

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForRenderInitial_Bool))]
        public void Render_RenderInitial_ReturnsRenderedField_Bool(int rows, int columns, bool lifeCell, bool deadCell, bool[][] result, (int row, int column)[] lifeCells) =>
            Assert.AreEqual(result, new GameOfLife(rows, columns, lifeCells).Render(lifeCell, deadCell));

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForRenderInitial_Char))]
        public void Render_RenderInitial_ReturnsRenderedField(int rows, int columns, char lifeCell, char deadCell, char[][] result, (int row, int column)[] lifeCells) =>
            Assert.AreEqual(result, new GameOfLife(rows, columns, lifeCells).Render(lifeCell, deadCell));

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForRenderNext_Int))]
        public void Next_RenderNext_ReturnsNextRenderedField_Int(int rows, int columns, int lifeCell, int deadCell, int[][] result, (int row, int column)[] lifeCells)
        {
            var playGround = new GameOfLife(rows, columns, lifeCells);
            playGround.Next();
            Assert.AreEqual(result, playGround.Render(lifeCell, deadCell));
        }

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForRenderNext_Bool))]
        public void Next_RenderNext_ReturnsNextRenderedField_Bool(int rows, int columns, bool lifeCell, bool deadCell, bool[][] result, (int row, int column)[] lifeCells)
        {
            var playGround = new GameOfLife(rows, columns, lifeCells);
            playGround.Next();
            Assert.AreEqual(result, playGround.Render(lifeCell, deadCell));
        }

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForRenderNext_Char))]
        public void Next_RenderNext_ReturnsNextRenderedField_Char(int rows, int columns, char lifeCell, char deadCell, char[][] result, (int row, int column)[] lifeCells)
        {
            var playGround = new GameOfLife(rows, columns, lifeCells);
            playGround.Next();
            Assert.AreEqual(result, playGround.Render(lifeCell, deadCell));
        }
    }
}