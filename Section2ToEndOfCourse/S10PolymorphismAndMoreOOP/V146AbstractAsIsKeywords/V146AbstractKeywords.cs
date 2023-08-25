using System;
namespace S10PolymorphismAndMoreOOP.V146AbstractAsIsKeywords
{
    public class V146AbstractKeywords
    {
        public static void Lesson()
        {
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach (var shape in shapes)
            {
                shape.GetInfo();

                Cube icecube = shape as Cube;
                if (icecube == null)
                {
                    Console.WriteLine("This shape is not a cube");
                }

                object cube1 = new Cube(7);
                Cube cube2 = (Cube)cube1;

                Console.WriteLine($"{cube2.Name} has a Volume of {cube2.Volume()}");
            }
        }
    }
}

