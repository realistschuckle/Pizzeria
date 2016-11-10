using System;

namespace Pizzeria.GenericPies
{
    public class Dough
    {
        private int _mixTime;
        private int _firstRiseTime;
        private int _secondRiseTime;

        public Dough(int mixTime, int firstRiseTime, int secondRiseTime, string flourType)
        {
            _mixTime = mixTime;
            _firstRiseTime = firstRiseTime;
            _secondRiseTime = secondRiseTime;

            if (flourType == "wheat")
            {
                _mixTime += 2;
                _firstRiseTime += 5;
            }
            else if (flourType == "cinnamon")
            {
                _mixTime += 5;
                _firstRiseTime -= 10;
                _secondRiseTime = Math.Max(0, _secondRiseTime - 10);
            }
        }

        public int MixTime
        {
            get { return _mixTime; }
        }

        public int FirstRiseTime
        {
            get { return _firstRiseTime; }
        }

        public int SecondRiseTime
        {
            get { return _secondRiseTime; }
        }

        public int TotalPreparationTime
        {
            get { return _mixTime + _firstRiseTime + _secondRiseTime; }
        }
    }
}
