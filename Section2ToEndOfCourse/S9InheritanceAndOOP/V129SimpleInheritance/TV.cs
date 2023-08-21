using System;
namespace S9InheritanceAndOOP
{
    public class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand) { }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV!");
            }
            else
            {
                Console.WriteLine("TV is switched off. Please switch on.");
            }
        }
    }
}

