using System;
namespace S9InheritanceAndOOP.V137IEnumeratorAndIEnumerable
{
    public class Dog
    {
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }

        public Dog(string name, bool isNaughtyDog)
        {
            Name = name;
            IsNaughtyDog = isNaughtyDog;
        }

        public void GiveTreat(int numberOfTreats)
        {
            Console.WriteLine($"Dog: {Name} said woof {numberOfTreats} times!");
        }
    }
}

