using System;
namespace S10PolymorphismAndMoreOOP.V145Abstract
{
    public class V145Abstract
    {
        public static void Lesson()
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Sphere(4),
                new Cube(3)
            };

            foreach (var shape in shapes)
            {
                shape.GetInfo();
            }
        }
    }
}

