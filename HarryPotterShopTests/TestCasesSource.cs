using HarryPotterShop;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HarryPotterShop.Tests
{
    internal class TestCasesSource
    {
        internal static IEnumerable<TestCaseData> ValidTestCasesForCalculateTotal
        {
            get
            {
                yield return new TestCaseData(new[] {
                    new Book() { BookPart = BookPart.PhilosophersStone } },
                    8m);
                yield return new TestCaseData(new[] {
                    new Book() { BookPart = BookPart.PhilosophersStone },
                    new Book() { BookPart = BookPart.PhilosophersStone } },
                    16m);
                yield return new TestCaseData(new[] {
                    new Book() { BookPart = BookPart.PhilosophersStone },
                    new Book() { BookPart = BookPart.ChamblerOfSecrets } },
                    15.2m);
                yield return new TestCaseData(new[] {
                    new Book() { BookPart = BookPart.PhilosophersStone },
                    new Book() { BookPart = BookPart.ChamblerOfSecrets },
                    new Book() { BookPart = BookPart.ChamblerOfSecrets } },
                    23.2m);
                yield return new TestCaseData(new[] {
                    new Book() { BookPart = BookPart.PhilosophersStone },
                    new Book() { BookPart = BookPart.PhilosophersStone },
                    new Book() { BookPart = BookPart.ChamblerOfSecrets } },
                    23.2m);
                yield return new TestCaseData(new[] {
                    new Book() { BookPart = BookPart.PhilosophersStone },
                    new Book() { BookPart = BookPart.OrderOfThePhoenix },
                    new Book() { BookPart = BookPart.ChamblerOfSecrets } },
                    21.6m);
                yield return new TestCaseData(new[] {
                    new Book() { BookPart = BookPart.PhilosophersStone },
                    new Book() { BookPart = BookPart.OrderOfThePhoenix },
                    new Book() { BookPart = BookPart.ChamblerOfSecrets },
                    new Book() { BookPart = BookPart.GobletOfFire } },
                    25.6m);
                yield return new TestCaseData(new[] {
                    new Book() { BookPart = BookPart.PhilosophersStone },
                    new Book() { BookPart = BookPart.OrderOfThePhoenix },
                    new Book() { BookPart = BookPart.ChamblerOfSecrets },
                    new Book() { BookPart = BookPart.GobletOfFire },
                    new Book() { BookPart = BookPart.PrisonerOfAzkaban } },
                    30m);
                yield return new TestCaseData(new[] {
                    new Book() { BookPart = BookPart.PhilosophersStone },
                    new Book() { BookPart = BookPart.PhilosophersStone },
                    new Book() { BookPart = BookPart.PrisonerOfAzkaban },
                    new Book() { BookPart = BookPart.PrisonerOfAzkaban },
                    new Book() { BookPart = BookPart.GobletOfFire },
                    new Book() { BookPart = BookPart.GobletOfFire },
                    new Book() { BookPart = BookPart.OrderOfThePhoenix },
                    new Book() { BookPart = BookPart.ChamblerOfSecrets } },
                    51.6m);
            }

        }
    }
}
