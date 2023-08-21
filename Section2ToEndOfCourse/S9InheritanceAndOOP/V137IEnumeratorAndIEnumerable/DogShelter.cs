using System;
using System.Collections;

namespace S9InheritanceAndOOP.V137IEnumeratorAndIEnumerable
{
    // this contains a generic collection of type Dog
    public class DogShelter : IEnumerable<Dog>
    {
        public List<Dog> Dogs;

        public DogShelter()
        {
            Dogs = new List<Dog>
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Whiskey", false),
                new Dog("Tango", false),
                new Dog("Foxtrot", true)
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return Dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

