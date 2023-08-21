using System;
namespace S9InheritanceAndOOP.V130VirtualAndOverride
{
    public class V130VirtualAndOverride
    {
        public static void Lesson()
        {
            var dog1 = new Dog("Whiskey", 4);
            Console.WriteLine($"{dog1.Name} is {dog1.Age} years old.");
            dog1.MakeSound();
            dog1.Play();
            dog1.Eat();
        }
    }
}

