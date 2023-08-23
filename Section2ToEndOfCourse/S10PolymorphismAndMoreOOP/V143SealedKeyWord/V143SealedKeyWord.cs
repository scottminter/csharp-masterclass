using System;
namespace S10PolymorphismAndMoreOOP.V143SealedKeyWord
{
    public class V143SealedKeyWord
    {
        public static void Lesson()
        {
            Dog dog1 = new Dog();
            dog1.MakeSound();

            Husky h1 = new Husky();
            h1.MakeSound();

            MiniHusky mh1 = new MiniHusky();
            mh1.MakeSound();
        }
    }
}

