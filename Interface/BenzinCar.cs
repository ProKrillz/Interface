using Interface.Interfaces;

namespace Interface;
public record BenzinCar : ICar
{
    public string Color { get; set; }
    public int Km { get; init; }
}
