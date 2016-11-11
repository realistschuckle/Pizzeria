using System;

namespace Pizzeria.CurtissimoPies
{
    public class CinnamonDough : IDough
    {
        private IDough _dough;

        public CinnamonDough(IDough dough)
        {
            _dough = dough;
        }

        public int FirstRiseTime
        {
            get { return Math.Max(0, _dough.FirstRiseTime - 10);}
        }

        public int MixTime
        {
            get { return _dough.MixTime + 5; }
        }

        public int SecondRiseTime
        {
            get { return Math.Max(0, _dough.SecondRiseTime - 10); }
        }

        public int TotalPreparationTime
        {
            get { return MixTime + FirstRiseTime + SecondRiseTime; }
        }

        public void ColorGreen()
        {
            _dough.ColorGreen();
        }
    }
}
