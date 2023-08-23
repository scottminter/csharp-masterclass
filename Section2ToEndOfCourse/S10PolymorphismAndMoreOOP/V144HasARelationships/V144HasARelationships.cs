using System;
namespace S10PolymorphismAndMoreOOP.V144HasARelationships
{
    public class V144HasARelationships
    {
        public static void Lesson()
        {
            Car bmwZ3 = new BMW(200, "black", "Z3");
            bmwZ3.ShowDetails();
            bmwZ3.SetCarIDInfo(12345, "Scott Minter");
            bmwZ3.GetCarIDInfo();
        }
    }
}

