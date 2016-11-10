using System;

namespace Pizzeria.CurtissimoPies
{
    public class HandTossedDough : Dough
    {
        public override int MixTime
        {
            get { return 5; }
        }

        public override int FirstRiseTime
        {
            get { return 30; }
        }

        public override int SecondRiseTime
        {
            get { return 30; }
        }
    }
}
