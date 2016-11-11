using NUnit.Framework;
using Pizzeria.CurtissimoPies;
using System;

namespace Pizzeria.Tests.CurtissmioPies
{
    [TestFixture]
    public class DoughTests
    {
        //                        TIMES(in minutes)
        // CRUST TYPE      MIX       FIRST RISE   SECOND RISE
        // ------------    ---       ----------   -----------
        // Thin             5            20
        // Pan              8            40            40
        // Hand-Tossed      5            30            30
        //
        // If a crust is made with wheat flour, add 2 minutes to the mix time
        // and 5 minutes to the first rise.
        //
        // If a crust is made with cinnamon, add 5 minutes to the mix time and
        // subtract 10 minutes from both rises.

        [Test]
        public void WheatDoughAddsTwoMinutesToTheMixTimeAndAddsFiveMinutesToTheFirstRiseTimesOfTheRealDough()
        {
            Dough[] doughs = new Dough[]
            {
                new ThinDough(),
                new PanDough(),
                new HandTossedDough()
            };

            foreach (Dough dough in doughs)
            {
                int oldMixTime = dough.MixTime;
                int oldFirstRiseTime = dough.FirstRiseTime;
                int oldSecondRiseTime = dough.SecondRiseTime;

                int expectedMixTime = oldMixTime + 2;
                int expectedFirstRiseTime = oldFirstRiseTime + 5;
                int expectedSecondRiseTime = oldSecondRiseTime;
                int expectedTotalTime = expectedMixTime + expectedFirstRiseTime + expectedSecondRiseTime;

                IDough fancyDough = new WheatDough(dough);
                int newMixTime = fancyDough.MixTime;
                int newFirstRiseTime = fancyDough.FirstRiseTime;
                int newSecondRiseTime = fancyDough.SecondRiseTime;
                int newTotalTime = fancyDough.TotalPreparationTime;

                Assert.That(newMixTime, Is.EqualTo(expectedMixTime));
                Assert.That(newFirstRiseTime, Is.EqualTo(expectedFirstRiseTime));
                Assert.That(newSecondRiseTime, Is.EqualTo(expectedSecondRiseTime));
                Assert.That(newFirstRiseTime, Is.GreaterThanOrEqualTo(0));
                Assert.That(newSecondRiseTime, Is.GreaterThanOrEqualTo(0));
                Assert.That(newTotalTime, Is.EqualTo(expectedTotalTime));
            }
        }

        [Test]
        public void CinnamonDoughAddsFiveMinutesToTheMixTimeAndSubtracts10MinutesFromTheRiseTimesOfTheRealDough()
        {
            Dough[] doughs = new Dough[]
            {
                new ThinDough(),
                new PanDough(),
                new HandTossedDough()
            };

            foreach (Dough dough in doughs)
            {
                int oldMixTime = dough.MixTime;
                int oldFirstRiseTime = dough.FirstRiseTime;
                int oldSecondRiseTime = dough.SecondRiseTime;

                int expectedMixTime = oldMixTime + 5;
                int expectedFirstRiseTime = Math.Max(oldFirstRiseTime - 10, 0);
                int expectedSecondRiseTime = Math.Max(oldSecondRiseTime - 10, 0);
                int expectedTotalTime = expectedMixTime + expectedFirstRiseTime + expectedSecondRiseTime;

                IDough fancyDough = new CinnamonDough(dough);
                int newMixTime = fancyDough.MixTime;
                int newFirstRiseTime = fancyDough.FirstRiseTime;
                int newSecondRiseTime = fancyDough.SecondRiseTime;
                int newTotalTime = fancyDough.TotalPreparationTime;

                Assert.That(newMixTime, Is.EqualTo(expectedMixTime));
                Assert.That(newFirstRiseTime, Is.EqualTo(expectedFirstRiseTime));
                Assert.That(newSecondRiseTime, Is.EqualTo(expectedSecondRiseTime));
                Assert.That(newFirstRiseTime, Is.GreaterThanOrEqualTo(0));
                Assert.That(newSecondRiseTime, Is.GreaterThanOrEqualTo(0));
                Assert.That(newTotalTime, Is.EqualTo(expectedTotalTime));
            }
        }

        [Test]
        public void HandTossedPizzaWithNormalCrustReportsCorrectTimes()
        {
            Dough dough = new HandTossedDough();

            Assert.That(dough.MixTime, Is.EqualTo(5));
            Assert.That(dough.FirstRiseTime, Is.EqualTo(30));
            Assert.That(dough.SecondRiseTime, Is.EqualTo(30));
            Assert.That(dough.TotalPreparationTime, Is.EqualTo(65));
        }

        [Test]
        public void AllGreenPizzasIncreaseMixTimeByThreeMinutes()
        {
            Dough[] doughs = new Dough[]
            {
                new ThinDough(),
                new PanDough(),
                new HandTossedDough()
            };

            foreach(Dough dough in doughs)
            {
                int originalMixTime = dough.MixTime;

                dough.ColorGreen();
                int newMixTime = dough.MixTime;

                Assert.That(newMixTime, Is.EqualTo(originalMixTime + 3));
            }
        }

        [Test]
        public void ThinPizzaWithNormalCrustReportsCorrectTimes()
        {
            Dough dough = new ThinDough();

            Assert.That(dough.MixTime, Is.EqualTo(5));
            Assert.That(dough.FirstRiseTime, Is.EqualTo(20));
            Assert.That(dough.SecondRiseTime, Is.EqualTo(0));
            Assert.That(dough.TotalPreparationTime, Is.EqualTo(25));
        }

        [Test]
        public void PanPizzaWithNormalCrustReportsCorrectTimes()
        {
            Dough dough = new PanDough();

            Assert.That(dough.MixTime, Is.EqualTo(8));
            Assert.That(dough.FirstRiseTime, Is.EqualTo(40));
            Assert.That(dough.SecondRiseTime, Is.EqualTo(40));
            Assert.That(dough.TotalPreparationTime, Is.EqualTo(88));
        }
    }
}
