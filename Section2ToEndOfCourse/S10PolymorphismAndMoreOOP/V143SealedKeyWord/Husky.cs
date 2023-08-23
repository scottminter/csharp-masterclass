using System;
namespace S10PolymorphismAndMoreOOP.V143SealedKeyWord
{
    class Husky : Dog
    {
        public Husky() { }

        public sealed override void MakeSound()
        {
            Console.WriteLine("Huskies go hooooowwwwwl");
        }
    }
}

