using System.Collections.Generic;
using NUnit.Framework;

#pragma warning disable S2368
#pragma warning disable CA1814

namespace Maze.Tests
{
    internal class TestCasesSource
    {
        public static IEnumerable<TestCaseData> TestCasesForMazePass
        {
            get
            {
                yield return new TestCaseData(
                    new bool[,]
                    {
                        { true, true, true, true, true, true },
                        { false, false, false, true, false, true },
                        { true, false, true, true, false, true },
                        { true, false, true, false, false, false },
                        { true, false, false, false, true, true },
                        { true, true, true, true, true, true },
                    },
                    3,
                    5,
                    new[] { (3, 5), (3, 4), (3, 3), (4, 3), (4, 2), (4, 1), (3, 1), (2, 1), (1, 1), (1, 0) });
                yield return new TestCaseData(
                    new bool[,]
                    {
                        { true, true, true, true, false, true },
                        { false, false, false, true, false, true },
                        { true, false, true, true, false, true },
                        { true, false, true, false, false, true },
                        { true, false, false, false, true, true },
                        { true, true, true, true, true, true },
                    },
                    0,
                    4,
                    new[] { (0, 4), (1, 4), (2, 4), (3, 4), (3, 3), (4, 3), (4, 2), (4, 1), (3, 1), (2, 1), (1, 1), (1, 0) });
                yield return new TestCaseData(
                    new bool[,]
                    {
                        { true, true, true, true, true, true, true, true, true, true, true, true },
                        { false, false, true, false, false, false, false, false, true, false, false, true },
                        { true, false, true, false, true, true, false, false, true, true, false, true },
                        { true, false, true, false, false, true, false, false, false, false, false, true },
                        { true, false, true, true, false, true, true, true, true, true, true, true },
                        { true, false, true, false, false, true, false, true, false, false, false, true },
                        { true, false, true, false, true, true, false, false, false, true, false, true },
                        { true, false, true, false, false, false, false, true, true, true, false, true },
                        { true, false, true, false, true, false, false, true, false, true, false, true },
                        { true, false, true, true, true, true, false, true, false, true, false, true },
                        { true, false, false, false, false, false, false, true, false, false, false, false },
                        { true, true, true, true, true, true, true, true, true, true, true, true },
                    },
                    1,
                    0,
                    new[] { (1, 0), (1, 1), (2, 1), (3, 1), (4, 1), (5, 1), (6, 1), (7, 1), (8, 1), (9, 1), (10, 1), (10, 2), (10, 3), (10, 4), (10, 5), (10, 6), (9, 6), (8, 6), (7, 6), (6, 6), (6, 7), (6, 8), (5, 8), (5, 9), (5, 10), (6, 10), (7, 10), (8, 10), (9, 10), (10, 10), (10, 11) });
                yield return new TestCaseData(
                    new bool[,]
                    {
                        { true, false, true, true, true, true, true, true, true, false, true, true },
                        { true, false, true, false, false, false, false, false, true, false, false, true },
                        { true, false, true, false, true, true, false, false, true, true, false, true },
                        { true, false, true, false, false, true, false, false, false, false, false, true },
                        { true, false, true, true, false, true, true, true, true, true, false, true },
                        { true, false, true, false, false, true, false, true, false, false, false, true },
                        { true, false, true, false, true, true, false, false, false, true, false, true },
                        { true, false, true, false, false, false, false, true, true, true, false, true },
                        { true, false, true, false, true, false, false, true, false, true, false, true },
                        { true, false, true, true, true, true, false, true, false, true, false, true },
                        { true, false, false, false, false, false, false, true, false, false, false, true },
                        { true, true, true, true, true, true, true, true, true, true, true, true },
                    },
                    0,
                    1,
                    new[] { (0, 1), (1, 1), (2, 1), (3, 1), (4, 1), (5, 1), (6, 1), (7, 1), (8, 1), (9, 1), (10, 1), (10, 2), (10, 3), (10, 4), (10, 5), (10, 6), (9, 6), (8, 6), (7, 6), (6, 6), (6, 7), (6, 8), (5, 8), (5, 9), (5, 10), (4, 10), (3, 10), (2, 10), (1, 10), (1, 9), (0, 9) });
                yield return new TestCaseData(
                    new bool[,]
                    {
                        { true, false, true, true, false, true, true, true, true, true, true, true },
                        { true, false, true, false, false, false, false, false, false, false, false, true },
                        { true, false, true, true, true, true, false, true, false, true, false, true },
                        { true, false, true, false, false, true, false, false, false, true, false, true },
                        { true, false, true, true, false, false, false, true, true, true, false, true },
                        { true, false, true, false, false, true, false, true, false, false, false, true },
                        { true, false, true, true, true, true, false, false, false, true, false, true },
                        { true, false, true, false, false, false, false, true, true, true, false, true },
                        { true, false, false, false, true, false, false, true, false, false, false, true },
                        { true, false, true, true, true, true, false, true, true, true, false, true },
                        { true, false, false, false, true, false, false, true, false, true, false, true },
                        { true, true, true, true, true, true, true, true, false, true, true, true },
                    },
                    0,
                    4,
                    new[] { (0, 4), (1, 4), (1, 5), (1, 6), (2, 6), (3, 6), (4, 6), (5, 6), (6, 6), (7, 6), (7, 5), (7, 4), (7, 3), (8, 3), (8, 2), (8, 1), (7, 1), (6, 1), (5, 1), (4, 1), (3, 1), (2, 1), (1, 1), (0, 1) });
                yield return new TestCaseData(
                    new bool[,]
                    {
                        { true, true, true, false, true, true, true, true, true, true, false, true },
                        { false, false, true, false, true, false, false, false, false, true, false, true },
                        { false, false, true, true, true, true, false, true, false, true, true, true },
                        { true, true, true, false, false, false, false, false, false, false, false, true },
                        { true, true, true, false, true, false, true, true, true, true, false, true },
                        { true, false, false, false, false, false, true, true, false, false, false, true },
                        { true, false, true, true, true, true, false, false, false, true, false, true },
                        { true, false, true, false, false, false, false, true, true, true, false, true },
                        { true, false, false, false, true, true, false, true, false, false, false, true },
                        { true, false, true, true, true, true, false, true, true, true, false, true },
                        { true, false, false, false, true, false, false, true, false, false, false, true },
                        { true, false, true, true, true, true, true, true, false, true, true, true },
                    },
                    11,
                    8,
                    new[] { (11, 8), (10, 8), (10, 9), (10, 10), (9, 10), (8, 10), (7, 10), (6, 10), (5, 10), (5, 9), (5, 8), (6, 8), (6, 7), (6, 6), (7, 6), (7, 5), (7, 4), (7, 3), (8, 3), (8, 2), (8, 1), (9, 1), (10, 1), (11, 1) });
            }
        }

        public static IEnumerable<TestCaseData> TestCasesForCtor
        {
            get
            {
                yield return new TestCaseData(
                    new bool[,]
                    {
                        { true, true, true, true, true, true },
                        { false, false, false, true, false, true },
                        { true, false, true, true, false, true },
                        { true, false, true, false, false, false },
                        { true, false, false, false, true, true },
                        { true, true, true, true, true, true },
                    });
            }
        }

        public static IEnumerable<TestCaseData> TestCasesNoPath
        {
            get
            {
                yield return new TestCaseData(
                    new bool[,]
                    {
                        { true, true, true, true, true, true },
                        { false, false, false, true, false, true },
                        { true, false, true, true, false, true },
                        { true, false, true, false, false, true },
                        { true, false, false, false, true, true },
                        { true, true, true, true, false, true },
                    });
            }
        }

        public static IEnumerable<TestCaseData> TestCasesForGetPass
        {
            get
            {
                yield return new TestCaseData(
                    new bool[,]
                    {
                        { true, true, true, true, true, true },
                        { false, false, false, true, false, true },
                        { true, false, true, true, false, true },
                        { true, false, true, false, false, false },
                        { true, false, false, false, true, true },
                        { true, true, true, true, true, true },
                    },
                    3,
                    5);
                yield return new TestCaseData(
                    new bool[,]
                    {
                        { true, true, true, true, true, true, true, true, true, true, true, true },
                        { false, false, true, false, false, false, false, false, true, false, false, true },
                        { true, false, true, false, true, true, false, false, true, true, false, true },
                        { true, false, true, false, false, true, false, false, false, false, false, true },
                        { true, false, true, true, false, true, true, true, true, true, true, true },
                        { true, false, true, false, false, true, false, true, false, false, false, true },
                        { true, false, true, false, true, true, false, false, false, true, false, true },
                        { true, false, true, false, false, false, false, true, true, true, false, true },
                        { true, false, true, false, true, false, false, true, false, true, false, true },
                        { true, false, true, true, true, true, false, true, false, true, false, true },
                        { true, false, false, false, false, false, false, true, false, false, false, false },
                        { true, true, true, true, true, true, true, true, true, true, true, true },
                    },
                    1,
                    0);
            }
        }
    }
}
