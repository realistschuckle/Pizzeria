namespace Pizzeria.CurtissimoPies
{
    public abstract class Dough
    {
        private int _additionalMixTime;

        public int TotalPreparationTime
        {
            get { return MixTime + FirstRiseTime + SecondRiseTime; }
        }

        public int MixTime
        {
            get { return _additionalMixTime + ChildMixTime; }
        }

        protected abstract int ChildMixTime { get; }

        public abstract int FirstRiseTime { get; }

        public abstract int SecondRiseTime { get; }

        public void ColorGreen()
        {
            _additionalMixTime = 3;
        }
    }
}
