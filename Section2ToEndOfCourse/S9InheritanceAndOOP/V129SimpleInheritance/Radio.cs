using System;

namespace S9InheritanceAndOOP
{
    public class Radio : ElectricalDevice
    {
        public Radio(bool isOn, string brand) : base(isOn, brand) { }

        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening to the Radio!");
            }
            else
            {
                Console.WriteLine("Radio is switched off. Please switch on.");
            }
        }
    }
}

