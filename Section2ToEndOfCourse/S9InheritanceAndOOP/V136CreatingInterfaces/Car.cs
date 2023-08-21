using System;
namespace S9InheritanceAndOOP.V136CreatingInterfaces
{
    public class Car : Vehicle, IDestroyable
    {
        // implementing interface prop
        public string DestructionSound { get; set; }

        public List<IDestroyable> DestroyablesNearby { get; set; }

        public Car()
        {
            DestructionSound = "DefaultCarExplosion.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public Car(float speed, string color) : base(speed, color)
        {
            DestructionSound = "CarExplosion.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        // implementing interface method
        public void Destroy()
        {
            Console.WriteLine($"Playing destruction sound {DestructionSound}.");
            Console.WriteLine("Create fire!");

            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}

