using System;
namespace S10PolymorphismAndMoreOOP.V143SealedKeyWord
{
    public class Dog : Animal
    {
        public Dog() { }

        public override void MakeSound()
        {
            Console.WriteLine("Dogs go woof");
        }
    }
}

