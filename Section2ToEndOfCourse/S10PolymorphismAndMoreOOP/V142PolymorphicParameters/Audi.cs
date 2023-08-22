using System;
namespace S10PolymorphismAndMoreOOP.V142PolymorphicParameters
{
    public class Audi : Car
    {
        private string _brand = "Audi";

        public string Model { get; set; }

        public Audi()
        {
            Model = "Generic Model";
        }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        // by using 'new' this method takes precedence over the inherited method
        public new void ShowDetails()
        {
            Console.WriteLine($"brand: {_brand}, color: {Color}, horsepower: {HP}");
        }

        public override void Repair()
        {
            Console.WriteLine($"This {Color} {_brand} has been repaired.");
        }
    }
}

