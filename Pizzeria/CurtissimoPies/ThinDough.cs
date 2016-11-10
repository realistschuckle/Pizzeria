using System;

namespace Pizzeria.CurtissimoPies
{
    public class ThinDough : Dough
    {
        public override int FirstRiseTime
        {
            get { return 20; }
        }

        public override int SecondRiseTime
        {
            get { return 0; }
        }

        protected override int ChildMixTime
        {
            get { return 5; }
        }
    }
}
