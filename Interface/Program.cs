using Interface;
public class Program
{
    public static void Main(String[] args)
    {
        BenzinCar car = new BenzinCar { Color = "White", Km = 31 };
        DieselCar car1 = new DieselCar { Color = "Black", Km = 140 };
        Console.WriteLine(car);
        Console.WriteLine(car1);
    }
}
