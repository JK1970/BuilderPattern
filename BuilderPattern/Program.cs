namespace BuilderPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Car car = new CarBuilder().SetBrand("VW").SetHp(230).SetSeats(7).SetEngine(new Engine(6)).GetProduct();
            Console.WriteLine(car);

            Car golf = CarDirector.BuildGolf();
            Console.WriteLine(golf);

            Car passat = CarDirector.BuildPassat();
            Console.WriteLine(passat);
        }
    }
}