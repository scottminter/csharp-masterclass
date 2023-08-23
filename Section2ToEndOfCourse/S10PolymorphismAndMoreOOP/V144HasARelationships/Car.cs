using System;
namespace S10PolymorphismAndMoreOOP.V144HasARelationships
{
    public class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // has a relationship
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine($"Car ID: {carIDInfo.IDNum}, Car Owner: {carIDInfo.Owner}");
        }

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

