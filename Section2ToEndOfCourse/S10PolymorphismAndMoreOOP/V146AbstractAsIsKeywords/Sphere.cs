using System;
namespace S10PolymorphismAndMoreOOP.V146AbstractAsIsKeywords
{
    class Sphere : Shape
    {
        private const double _pi = 3.14159265359;

        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }

        public override double Volume()
        {
            // V = 4/3 pi * r^3
            return (4.0 / 3.0) * _pi * Math.Pow(Radius, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"The {Name} has a radius of {Radius} and a volume of {Volume()}");
        }
    }
}

