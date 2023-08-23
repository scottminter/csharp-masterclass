using System;
namespace S10PolymorphismAndMoreOOP.V144HasARelationships
{
    public class BMW : Car
    {
        private string _brand = "BMW";

        public string Model { get; set; }

        public BMW()
        {
            Model = "Generic Model";
        }

        public BMW(int hp, string color, string model) : base(hp, color)
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

