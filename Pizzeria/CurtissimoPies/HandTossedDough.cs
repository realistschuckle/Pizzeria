namespace Pizzeria.CurtissimoPies
{
    public class HandTossedDough : Dough
    {
        public override int FirstRiseTime
        {
            get { return 30; }
        }

        public override int SecondRiseTime
        {
            get { return 30; }
        }

        protected override int ChildMixTime
        {
            get { return 5; }
        }
    }
}
