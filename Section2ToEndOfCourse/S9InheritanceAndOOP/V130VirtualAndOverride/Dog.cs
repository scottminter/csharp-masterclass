using System;
namespace S9InheritanceAndOOP.V130VirtualAndOverride
{
    public class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string name, int age) : base(name, age)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wooooooffff!!!");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
}

