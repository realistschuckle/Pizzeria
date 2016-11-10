namespace Pizzeria.CurtissimoPies
{
    public class PanDough : Dough
    {
        public override int FirstRiseTime
        {
            get { return 40; }
        }

        public override int SecondRiseTime
        {
            get { return 40; }
        }

        protected override int ChildMixTime
        {
            get { return 8; }
        }
    }
}
