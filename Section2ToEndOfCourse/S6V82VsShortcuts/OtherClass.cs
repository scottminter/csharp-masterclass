using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace S6V82VsShortcuts
{
    public class OtherClass : IOtherClass
    {
        public OtherClass()
        {
            Console.WriteLine("You created an OtherClass");
        }

        public void AnotherMethod()
        {
            Console.WriteLine("You called another method");
        }

        public void FooBar()
        {
            // 
        }
    }
}
