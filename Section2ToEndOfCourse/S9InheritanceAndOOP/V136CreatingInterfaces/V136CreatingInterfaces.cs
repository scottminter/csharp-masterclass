using System;
namespace S9InheritanceAndOOP.V136CreatingInterfaces
{
    public class V136CreatingInterfaces
    {
        public static void Lesson()
        {
            var car1 = new Car();
            Console.WriteLine($"car1 speed: {car1.Speed} - color: {car1.Color}");
            var car2 = new Car(150, "Silver");
            Console.WriteLine($"car2 speed: {car2.Speed} - color: {car2.Color}");

            var chair1 = new Chair();
            Console.WriteLine($"chair1 color: {chair1.Color} - material: {chair1.Material}");
            var chair2 = new Chair("red", "plywood and metal");
            Console.WriteLine($"chair2 color: {chair2.Color} - material: {chair2.Material}");

            car1.DestroyablesNearby.Add(car2);
            car1.DestroyablesNearby.Add(chair1);
            car1.DestroyablesNearby.Add(chair2);

            car1.Destroy();

        }
    }
}

