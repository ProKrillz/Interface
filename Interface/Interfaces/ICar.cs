namespace Interface.Interfaces;

public enum Colors
{
    White,
    Red,
    Green,
    Blue,
    Yellow,
}

internal interface ICar {
    public Colors Color { get; set; }
    public int Km { get; init; }
}

