using Interface.Interfaces;

namespace Interface
{
    public record BenzinCar : ICar
    {
        public string Color { get; init; }
        public int Km { get; init; }
    }
}
