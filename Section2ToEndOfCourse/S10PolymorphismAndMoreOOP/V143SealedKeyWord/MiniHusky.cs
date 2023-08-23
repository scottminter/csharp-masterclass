using System;
namespace S10PolymorphismAndMoreOOP.V143SealedKeyWord
{
    class MiniHusky : Husky
    {
        public MiniHusky()
        {
        }

        // cannot override because husky makesound method is sealed
        public new void MakeSound()
        {
            Console.WriteLine("Mini huskies go hoowwl");
        }
    }
}

