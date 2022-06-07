using Interface.Interfaces;

namespace Interface;

public record DieselCar : ICar
{
    public string Color { get; set; }
    public int Km { get; init; }
}
