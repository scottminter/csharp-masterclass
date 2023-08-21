using System;
namespace S9InheritanceAndOOP
{
    public class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }
        public string DeviceType { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
            DeviceType = this.GetType().Name;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }

        public void WhatIsThis()
        {
            var howToConsume = DeviceType == "Radio" ? "listening to" : "watching";
            var watchingState = IsOn == true ? "are" : "are not";
            Console.WriteLine($"You {watchingState} {howToConsume} your {Brand} {DeviceType}.");
        }
    }
}

