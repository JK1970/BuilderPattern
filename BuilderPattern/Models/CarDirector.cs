using BuilderPattern;

namespace BuilderPattern
{
    public class CarDirector
    {
        public static Car BuildGolf()
        {
            return new CarBuilder().SetBrand("VW").SetHp(200).SetSeats(5).SetEngine(new Engine(4)).GetProduct();
        }

        public static Car BuildPassat()
        {
            return new CarBuilder().SetBrand("VW").SetHp(250).SetSeats(6).SetEngine(new Engine(6)).GetProduct();
        }
    }
}