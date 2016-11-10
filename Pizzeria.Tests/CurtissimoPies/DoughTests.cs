using NUnit.Framework;
using Pizzeria.CurtissimoPies;

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
        public void HandTossedPizzaWithNormalCrustReportsCorrectTimes()
        {
            Dough dough = new HandTossedDough();

            Assert.That(dough.MixTime, Is.EqualTo(5));
            Assert.That(dough.FirstRiseTime, Is.EqualTo(30));
            Assert.That(dough.SecondRiseTime, Is.EqualTo(30));
            Assert.That(dough.TotalPreparationTime, Is.EqualTo(65));
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
