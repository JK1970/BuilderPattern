namespace BuilderPattern.Models
{
    public class CarBuilder
    {
        private readonly Car _car;
        public CarBuilder()
        {
            _car = new Car();
        }

        public CarBuilder SetBrand(string brand)
        {
            _car.Brand = brand;
            return this;
        }

        public CarBuilder SetSeats(int seats)
        {
            _car.Seats = seats;
            return this;
        }

        public CarBuilder SetHp(int hp)
        {
            _car.Hp = hp;
            return this;
        }

        public CarBuilder SetEngine(Engine engine)
        {
            _car.Engine = engine;
            return this;
        }

        public Car GetProduct()
        {
            return _car;
        }
    }
}