using System;
namespace S9InheritanceAndOOP.V136CreatingInterfaces
{
    public class Chair : Furniture, IDestroyable
    {
        public string DestructionSound { get; set; }

        public List<IDestroyable> DestroyablesNearby { get; set; }

        public Chair()
        {
            DestructionSound = "DefaultCharDestruction.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public Chair(string color, string material) : base(color, material)
        {
            DestructionSound = "ChairDestruction.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine($"The {Color} char was destroyed.");
            Console.WriteLine($"Playing destruction sound {DestructionSound}.");
            Console.WriteLine("Spawning chair parts.");
        }
    }
}

