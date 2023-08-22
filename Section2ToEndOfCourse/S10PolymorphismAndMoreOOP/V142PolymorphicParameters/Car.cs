using System;
namespace S10PolymorphismAndMoreOOP.V142PolymorphicParameters
{
    public class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car()
        {
            HP = 0;
            Color = "White";
        }

        public Car(int hp, string color)
        {
            HP = hp;
            Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"color: {Color}, horsepower: {HP}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired!");
        }
    }
}

