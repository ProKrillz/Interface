using Interface.Interfaces;

namespace Interface;

public record DieselCar : ICar
{
    public Colors Color { get; set; }
    public int Km { get; init; }
}
