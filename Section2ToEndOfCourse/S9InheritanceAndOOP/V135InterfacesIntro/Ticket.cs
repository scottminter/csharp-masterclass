using System;
namespace S9InheritanceAndOOP.V135InterfacesIntro
{
    public class Ticket : IEquatable<Ticket>
    {
        // prop to store the duration of the ticket in hours
        public int DurationInHours { get; set; }

        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("other", "You cannot pass null to this method.  Null cannot be equated except to itself.");
            }

            return DurationInHours == other.DurationInHours;
        }
    }
}

