using System;

namespace Pizzeria.ProceduralPies
{
    public class Dough
    {
        public int CalculateTotalPreparationTime(int mixTime, int firstRiseTime, int secondRiseTime, string flourType)
        {
            if (flourType == "wheat")
            {
                mixTime += 2;
                firstRiseTime += 5;
            }
            else if (flourType == "cinnamon")
            {
                mixTime += 5;
                firstRiseTime -= 10;
                secondRiseTime = Math.Max(0, secondRiseTime - 10);
            }
            return mixTime + firstRiseTime + secondRiseTime;
        }
    }
}
