using System;
namespace S10PolymorphismAndMoreOOP.V146AbstractAsIsKeywords
{
    // Abstract classes can't be instantiated
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a a {Name}");
        }

        // do not implement abstract methods
        // the implementation happens in the classes
        // that inherit from the class
        public abstract double Volume();
    }
}

