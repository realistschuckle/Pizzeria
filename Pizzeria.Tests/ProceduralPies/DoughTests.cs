using NUnit.Framework;
using Pizzeria.ProceduralPies;

namespace Pizzeria.Tests.ProceduralPies
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
        [TestCase(5, 20, 0, "white", 5, 20, 0, 25)]
        [TestCase(8, 40, 40, "white", 8, 40, 40, 88)]
        [TestCase(5, 30, 30, "white", 5, 30, 30, 65)]
        [TestCase(5, 20, 0, "wheat", 7, 25, 0, 32)]
        [TestCase(8, 40, 40, "wheat", 10, 45, 40, 95)]
        [TestCase(5, 30, 30, "wheat", 7, 35, 30, 72)]
        [TestCase(5, 20, 0, "cinnamon", 10, 10, 0, 20)]
        [TestCase(8, 40, 40, "cinnamon", 13, 30, 30, 73)]
        [TestCase(5, 30, 30, "cinnamon", 10, 20, 20, 50)]
        public void TestDoughTimes(int mix, int firstRise, int secondRise, string flour, int expectedMix, int expectedFirstRise, int expectedSecondRise, int expectedTotalTime)
        {
            Dough dough = new Dough();

            int totalTime = dough.CalculateTotalPreparationTime(mix, firstRise, secondRise, flour);

            Assert.That(totalTime, Is.EqualTo(expectedTotalTime));
        }
    }
}
