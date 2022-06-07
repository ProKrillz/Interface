using Interface.Interfaces;

namespace Interface;
public record BenzinCar : ICar
{
    public Colors Color { get; set; }
    public int Km { get; init; }
}
