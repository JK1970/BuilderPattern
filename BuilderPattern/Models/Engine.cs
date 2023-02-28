namespace BuilderPattern.Models
{
    public class Engine
    {
        public int Cylinder { get; set; }

        public Engine(int cylinder)
        {
            Cylinder = cylinder;
        }
        public override string ToString()
        {
            return Cylinder.ToString();
        }
    }
}