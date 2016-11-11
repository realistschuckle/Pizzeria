namespace Pizzeria.CurtissimoPies
{
    public class WheatDough : IDough
    {
        private IDough _dough;

        public WheatDough(IDough dough)
        {
            _dough = dough;
        }

        public int FirstRiseTime
        {
            get { return _dough.FirstRiseTime + 5; }
        }

        public int MixTime
        {
            get { return _dough.MixTime + 2; }
        }

        public int SecondRiseTime
        {
            get { return _dough.SecondRiseTime; }
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
