using Interface.Interfaces;

namespace Interface;
public struct Car : ICar
{
    public Colors Color { get; set; }
    public int Km { get; init; }
    public int Hk { get; init; }

    public string GetInfo()
    {
        return $"Color: {Color}\nKm: {Km}\nHk: {Hk}\n";
    }
}