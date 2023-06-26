using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesAndVariables
{
    public class StringManipulation
    {
        public void Lesson()
        {
            int age = 42;
            string name = "Scott";
            string job = "Developer";

            // concatenation
            Console.WriteLine("Concatenation: " + name + " concatenated with " + age.ToString() + "\n");

            // string formatting uses indexes
            Console.WriteLine("Indexes: Hello I am {0} and I am {1} years old. I work as a {2}.\n", name, age, job);

            // interpolation
            Console.WriteLine($"Interpolation: My name is {name}.  I am {age} years old.  I work as a {job}.\n");

            // verbatim strings
            // start with @ and tells the comiler to take the string literally and ignore any spaces and
            // escape characters like \n
            Console.WriteLine(@"Verbatim: Deadlights jack lad schooner scallywag dance the hempen jig carouser broadside cable strike colors. 
                                Bring a spring upon her cable holystone blow the man down spanker Shiver me timbers to go on account lookout 
                                wherry doubloon chase. Belay yo-ho-ho keelhaul squiffy black spot yardarm spyglass sheet transom heave to.\n");

            Console.WriteLine(@"Verbatim for filepath: \var\www\html\index.html");

            Console.WriteLine("\n");
        }
    }
}
