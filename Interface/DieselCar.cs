using Interface.Interfaces;

namespace Interface
{
    public record DieselCar : ICar
    {
        public string Color { get; init; }
        public int Km { get; init; }
    }
}
