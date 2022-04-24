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
                yield return new TestCaseData(1, 1, new[] { (-1, 1) });
                yield return new TestCaseData(1, 1, new[] { (1, -1) });
                yield return new TestCaseData(2, 2, new[] { (1, 1), (2, 1) });
                yield return new TestCaseData(2, 2, new[] { (1, 1), (1, 2) });
                yield return new TestCaseData(10, 10, new[] { (5, 0), (int.MaxValue, int.MinValue) });
            }
        }

        public static IEnumerable<TestCaseData> TestCasesForRenderInitial_Int
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
                    new[] { (3, 2), (2, 3), (4, 4) });
            }
        }
        public static IEnumerable<TestCaseData> TestCasesForRenderInitial_Bool
        {//int rows, int columns,T lifeCell, T deadCell, T[][] result, params (int row, int column)[] lifeCells
            get
            {
                yield return new TestCaseData(
                    3, 6, true, false,
                    new bool[][]
                    {
                        new bool[] { false, false, false, false, false, false },
                        new bool[] { false, true, false, false, false, false },
                        new bool[] { false, false, false, true, false, false },
                    },
                    new[] { (2, 3), (1, 1) });
            }
        }
        public static IEnumerable<TestCaseData> TestCasesForRenderInitial_Char
        {//int rows, int columns,T lifeCell, T deadCell, T[][] result, params (int row, int column)[] lifeCells
            get
            {
                yield return new TestCaseData(
                    5, 5, '*', '.',
                    new char[][]
                    {
                        new char[] { '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', '.', '.' },
                        new char[] { '.', '.', '.', '*', '.' },
                        new char[] { '.', '.', '*', '.', '.' },
                        new char[] { '.', '.', '.', '.', '*' },
                    },
                    new[] { (3, 2), (2, 3), (4, 4) });
            }
        }

        public static IEnumerable<TestCaseData> TestCasesForRenderNext_Int
        {
            get
            {
                yield return new TestCaseData(
                    5, 5, 1, 0,
                    new int[][]
                    {
                        new int[] { 0, 0, 0, 0, 0 },
                        new int[] { 0, 0, 0, 0, 0 },
                        new int[] { 0, 0, 0, 0, 0 },
                        new int[] { 0, 0, 0, 1, 0 },
                        new int[] { 0, 0, 0, 0, 0 },
                    },
                    new[] { (3, 2), (2, 3), (4, 4) });
            }
        }

        public static IEnumerable<TestCaseData> TestCasesForRenderNext_Bool
        {
            get
            {
                yield return new TestCaseData(
                    3, 6, true, false,
                    new bool[][]
                    {
                        new bool[] { true, true, false, false, false, false },
                        new bool[] { true, true, false, false, false, false },
                        new bool[] { false, false, false, false, false, false },
                    },
                    new[] { (0, 0), (1, 1), (1, 0) });
            }
        }
        public static IEnumerable<TestCaseData> TestCasesForRenderNext_Char
        {
            get
            {
                yield return new TestCaseData(
                    5, 5, '*', '.',
                    new char[][]
                    {
                        new char[] { '.', '.', '.', '.', '.' },
                        new char[] { '.', '*', '.', '.', '.' },
                        new char[] { '.', '.', '*', '*', '.' },
                        new char[] { '.', '*', '*', '.', '.' },
                        new char[] { '.', '.', '.', '.', '.' },
                    },
                    new[] { (2, 0), (3, 1), (1, 2), (2, 2), (3, 2) });
            }
        }
    }
}
