namespace Pizzeria.CurtissimoPies
{
    public abstract class Dough
    {
        public int TotalPreparationTime
        {
            get { return MixTime + FirstRiseTime + SecondRiseTime; }
        }

        public abstract int MixTime { get; }

        public abstract int FirstRiseTime { get; }

        public abstract int SecondRiseTime { get; }
    }
}
