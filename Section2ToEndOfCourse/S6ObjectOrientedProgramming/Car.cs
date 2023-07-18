using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S6ObjectOrientedProgramming
{
    public class Car
    {
        // Member variables
        // access modifier private
        private string _name;
        private int _hp;
        private string _color;

        public void SetName(string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                _name = name;
            }
        }

        public string GetName()
        {
            return _name;
        }

        // default constructor
        public Car()
        {
            _name = "Generic Car";
            _hp = 0;
            _color = "No Color";
        }

        public Car(string name, int hp = 0, string color = "black")
        {
            _name = name;
            _hp = hp;
            _color = color;

            Console.WriteLine($"{_name} was created.");
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
                              $"{_hp} horsepower.");
        }
    }
}
