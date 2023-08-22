using System;

namespace S10PolymorphismAndMoreOOP.V142PolymorphicParameters
{
    public class V142PolymorphicParameters
    {
        public static void Lesson()
        {
            Car bmw1 = new BMW(360, "black", "X6");
            bmw1.ShowDetails();

            Car audi1 = new Audi(295, "red", "A6");
            audi1.ShowDetails();

            BMW bmw2 = new BMW(150, "silver", "X7");
            bmw2.ShowDetails();

            Audi audi2 = new Audi(138, "gray", "A5");
            audi2.ShowDetails();

            Console.WriteLine("\n");

            List<Car> cars = new List<Car>()
            {
                bmw1,
                audi1,
                bmw2,
                audi2
            };

            foreach (Car car in cars)
            {
                car.Repair();
            }
        }
    }
}

