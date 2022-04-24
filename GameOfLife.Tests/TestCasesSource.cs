using System.Collections.Generic;
using NUnit.Framework;

namespace GameOfLife.Tests
{
    internal class TestCasesSource
    {
        public static IEnumerable<TestCaseData> TestCasesForInvalidLifeCell
        {//int rows, int columns, params (int row, int column)[] lifeCells
            get
            {
                yield return new TestCaseData(1, 1, (-1, 1));
                yield return new TestCaseData(1, 1, (1, -1));
                yield return new TestCaseData(2, 2, (1, 1), (2, 1));
                yield return new TestCaseData(2, 2, (1, 1), (1, 2));
                yield return new TestCaseData(10, 10, (5, 0), (int.MaxValue, int.MinValue));
            }
        }

        public static IEnumerable<TestCaseData> TestCasesForRenderInitial
        {//int rows, int columns,T lifeCell, T deadCell, T[][] result, params (int row, int column)[] lifeCells
            get
            {
                yield return new TestCaseData(
                    5, 5, 1, 0, 
                    new int[][]
                    {
                        new int[] { 0, 0, 0, 0, 0 },
                        new int[] { 0, 0, 0, 0, 0 },
                        new int[] { 0, 0, 0, 1, 0 },
                        new int[] { 0, 0, 1, 0, 0 },
                        new int[] { 0, 0, 0, 0, 1 },
                    },
                    (3, 2), (2, 3), (4, 4));

                yield return new TestCaseData(
                    3, 6, true, false,
                    new bool[][]
                    {
                        new bool[] { false, false, false, false, false, false },
                        new bool[] { false, true, false, false, false, false },
                        new bool[] { false, false, false, true, false, false },
                    },
                    (2, 3), (1, 1));

                yield return new TestCaseData(
                    5, 5, 1, 0,
                    new char[][]
                    {
                        new char[] { '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', '*', '.' },
                        new char[] { '.', '.', '*', '.', '.' },
                        new char[] { '.', '.', '.', '.', '*' },
                    },
                    (3, 2), (2, 3), (4, 4));
            }
        }

        public static IEnumerable<TestCaseData> TestCasesForRenderNext
        {
            get
            {
                yield return new TestCaseData(
                    5, 5, 1, 0,
                    new int[][]
                    {
                        new int[] { 0, 0, 0, 0, 0 },
                        new int[] { 0, 0, 0, 0, 0 },
                        new int[] { 0, 0, 0, 1, 0 },
                        new int[] { 0, 0, 1, 1, 0 },
                        new int[] { 0, 0, 0, 0, 0 },
                    },
                    (3, 2), (2, 3), (4, 4));

                yield return new TestCaseData(
                    3, 6, true, false,
                    new bool[][]
                    {
                        new bool[] { false, false, false, false, false, false },
                        new bool[] { false, false, false, false, false, false },
                        new bool[] { false, false, false, false, false, false },
                    },
                    (2, 3), (1, 1));

                yield return new TestCaseData(
                    5, 5, 1, 0,
                    new char[][]
                    {
                        new char[] { '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', '*', '.' },
                        new char[] { '.', '.', '*', '*', '.' },
                        new char[] { '.', '.', '.', '.', '.' },
                    },
                    (3, 2), (2, 3), (4, 4));
            }
        }
    }
}
