using System;

namespace S9InheritanceAndOOP
{
    public class V129SimpleInheritance
    {
        public static void Lesson()
        {
            Console.WriteLine("V129");

            var rad1 = new Radio(true, "Emerson");
            rad1.ListenRadio();
            rad1.SwitchOff();
            rad1.ListenRadio();
            rad1.WhatIsThis();

            var tv1 = new TV(false, "Sony");
            tv1.WatchTV();
            tv1.SwitchOn();
            tv1.WatchTV();
            tv1.WhatIsThis();
        }
    }
}

