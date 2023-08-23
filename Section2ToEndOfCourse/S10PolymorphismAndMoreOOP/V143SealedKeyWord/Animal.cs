using System;
namespace S10PolymorphismAndMoreOOP.V143SealedKeyWord
{
    public class Animal
    {
        public Animal() { }

        public virtual void MakeSound()
        {
            Console.WriteLine("Making a generic animal sound");
        }
    }
}

