using System;
namespace S9InheritanceAndOOP.V135InterfacesIntro
{
    public class V135InterfacesIntro
    {
        public static void Lesson()
        {
            var t1 = new Ticket(10);
            var t2 = new Ticket(11);
            if (t1.Equals(t2))
            {
                Console.WriteLine("T1 equals T2");
            }
            else
            {
                Console.WriteLine("T1 does not equal T2");
            }
        }
    }
}

