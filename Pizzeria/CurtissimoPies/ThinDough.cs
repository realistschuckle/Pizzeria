using System;

namespace Pizzeria.CurtissimoPies
{
    public class ThinDough : Dough
    {
        public override int FirstRiseTime
        {
            get { return 20; }
        }

        public override int MixTime
        {
            get { return 5; }
        }

        public override int SecondRiseTime
        {
            get { return 0; }
        }
    }
}
