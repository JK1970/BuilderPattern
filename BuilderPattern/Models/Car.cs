namespace BuilderPattern.Models
{
    public class Car
    {
        public string? Brand { get; set; }
        public int Seats { get; set; }
        public int Hp { get; set; }
        public Engine? Engine { get; set; }

        public override string ToString()
        {
            return "\nBrand  : " + Brand +
                   "\nSeats  : " + Seats +
                   "\nHp     : " + Hp +
                   "\nEngine : " + Engine + "\n";
        }
    }
}