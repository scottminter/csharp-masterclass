using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6ObjectOrientedProgramming
{
    public class Car
    {
        // Member variables/fields
        // access modifier private
        private string _name;
        private int _hp;
        private string _color;
        private int _maxSpeed;

        // Auto implemented property
        public int MaxSpeed
        {
            set
            {
                _maxSpeed = value;
            }
        } // with { get; set; } this will automatically create a private _maxSpeed field

        // public properties
        public string Name
        {
            get { return _name; } // get accessor
            set
            {
                _name = value != String.Empty ? value : "Some Default Value";
            } // set accessor
        }

        public int Hp
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        // default constructor
        public Car()
        {
            _name = "Generic Car";
            _hp = 0;
            _color = "No Color";
            _maxSpeed = 0;
        }

        public Car(string name, int hp = 0, string color = "black", int maxSpeed = 0)
        {
            _name = name;
            _hp = hp;
            _color = color;
            _maxSpeed = maxSpeed;
        }

        public void Drive()
        {
            Console.WriteLine($"{_name} is driving.");
        }

        public void Stop()
        {
            Console.WriteLine($"{_name} is stopping.");
        }

        public void Details()
        {
            Console.WriteLine($"The {_color} " +
                              $"{_name} has " +
                              $"{_hp} horsepower " +
                              $"and a maximum speed of {_maxSpeed}.\n");
        }
    }
}
