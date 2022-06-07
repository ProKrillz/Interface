using Interface;
public class Program
{
    public static void Main(String[] args)
    {
        BenzinCar car = new BenzinCar { Color = "White", Km = 31 };
        DieselCar car1 = new DieselCar { Color = "Black", Km = 140 };
        Console.WriteLine(car);
        Console.WriteLine(car1);
        Car car3 = new Car { Color = "Green", Km = 55, Hk = 120};
        Console.WriteLine(car3.GetInfo());
        Car car4 = car3;
        //car4 og 3 har pointer til samme object i heapen.
    }
}
