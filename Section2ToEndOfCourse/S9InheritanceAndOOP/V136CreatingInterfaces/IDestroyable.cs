using System;
namespace S9InheritanceAndOOP.V136CreatingInterfaces
{
    public interface IDestroyable
    {
        string DestructionSound { get; set; }

        void Destroy();
    }
}

