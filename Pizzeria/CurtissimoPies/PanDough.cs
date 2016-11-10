namespace Pizzeria.CurtissimoPies
{
    public class PanDough : Dough
    {
        public override int FirstRiseTime
        {
            get { return 40; }
        }

        public override int MixTime
        {
            get { return 8; }
        }

        public override int SecondRiseTime
        {
            get { return 40; }
        }
    }
}
