// See https://aka.ms/new-console-template for more information

using S6ObjectOrientedProgramming;

var car1 = new Car("Audi", 250, color: "grey");
car1.Drive();

var car2 = new Car("BMW", 350, color: "white");
car2.Drive();

var car3 = new Car();
car3.SetName("");
var car3Name = car3.GetName();
Console.WriteLine($"car 3 name: {car3Name}");

car1.Details();
car2.Details();
car3.Details();

Console.Write("Press 1 to stop the car: ");
var userInput = Console.ReadLine();
if (userInput == "1")
{
    car1.Stop();
}
else
{
    Console.WriteLine("Car is still driving");    
}

Console.Read();

