using Interface.Interfaces;

namespace Interface;
public struct Car : ICar
{
    public string Color { get; set; }
    public int Km { get; init; }
    public int Hk { get; init; }

    public string GetInfo()
    {
        return $"Color: {Color}\nKm: {Km}\nHk: {Hk}\n";
    }
}
