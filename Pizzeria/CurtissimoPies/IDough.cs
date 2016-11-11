namespace Pizzeria.CurtissimoPies
{
    public interface IDough
    {
        int FirstRiseTime { get; }

        int MixTime { get; }

        int SecondRiseTime { get; }

        int TotalPreparationTime { get; }

        void ColorGreen();
    }
}