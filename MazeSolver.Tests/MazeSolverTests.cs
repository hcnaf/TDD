using System;
using System.Linq;
using NUnit.Framework;

#pragma warning disable CA1707

namespace Maze.Tests
{
    [TestFixture]
    public class MazeSolverTests
    {
        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForMazePass))]
        public void GetPass_SuccessfulTests(bool[,] maze, int row, int column, (int, int)[] expected)
        {
            var solver = new MazeSolver(maze, row, column);
            solver.PassMaze();
            var actual = solver.GetPath();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForMazePass))]
        public void GetExit_SuccessfulTests(bool[,] maze, int row, int column, (int, int)[] expected)
        {
            var solver = new MazeSolver(maze, row, column);
            solver.PassMaze();
            var actual = solver.GetPath();
            Assert.AreEqual(actual.Last(), expected.Last());
        }

        [Test]
        public void MazeSolverConstructor_MatrixIsNull_ThrowArgumentNullException()
            => Assert.Throws<ArgumentNullException>(() => new MazeSolver(null, 1, 2));

        [Test]
        public void MazeSolverConstructor_MatrixIsEmpty_ThrowArgumentException()
            => Assert.Throws<ArgumentException>(() => new MazeSolver(new bool[,] { { } }, 1, 2));

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForCtor))]
        public void MazeSolverConstructor_RowStartLessThanZero_ThrowArgumentOutOfRangeException(bool[,] maze)
            => Assert.Throws<ArgumentOutOfRangeException>(() => new MazeSolver(maze, -12, 2));

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForCtor))]
        public void MazeSolverConstructor_ColumnStartLessThanZero_ThrowArgumentOutOfRangeException(bool[,] maze)
            => Assert.Throws<ArgumentOutOfRangeException>(() => new MazeSolver(maze, 0, -2));

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForCtor))]
        public void MazeSolverConstructor_RowStartThanMoreThanDimension_ThrowArgumentOutOfRangeException(bool[,] maze)
            => Assert.Throws<ArgumentOutOfRangeException>(() => new MazeSolver(maze, 100, 2));

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForCtor))]
        public void MazeSolverConstructor_ColumnStartMoreThanDimension_ThrowArgumentOutOfRangeException(bool[,] maze)
            => Assert.Throws<ArgumentOutOfRangeException>(() => new MazeSolver(maze, 0, 100));

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesNoPath))]
        public void PassMaze_NoPath_ThrowInvalidOperationException(bool[,] mazeModel)
        {
            var mazeSolver = new MazeSolver(mazeModel, 1, 0);
            Assert.Throws<InvalidOperationException>(() => mazeSolver.PassMaze());
        }

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForGetPass))]
        public void GetPath_PassMazeMethodWasNotStarted_ThrowInvalidOperationException(bool[,] maze, int row, int column)
        {
            var solver = new MazeSolver(maze, row, column);
            Assert.Throws<InvalidOperationException>(() => solver.GetPath());
        }

        [TestCaseSource(typeof(TestCasesSource), nameof(TestCasesSource.TestCasesForGetPass))]
        public void GetExit_PassMazeMethodWasNotStarted_ThrowInvalidOperationException(bool[,] maze, int row, int column)
        {
            var solver = new MazeSolver(maze, row, column);
            Assert.Throws<InvalidOperationException>(() => solver.GetExit());
        }
    }
}
