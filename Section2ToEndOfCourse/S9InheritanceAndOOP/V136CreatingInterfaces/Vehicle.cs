using System;
namespace S9InheritanceAndOOP.V136CreatingInterfaces
{
    public class Vehicle
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        public Vehicle()
        {
            Speed = 0.0f;
            Color = "White";
        }

        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}

