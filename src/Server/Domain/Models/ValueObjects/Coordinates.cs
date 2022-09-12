using Domain.Types;

namespace Domain.Models.ValueObjects
{
    internal record Coordinates : ValueObject<Coordinates, string>
    {
        public double Latitude { get; init; }
        public double Longitude { get; init; }

        public Coordinates(long latitude, long longitude)
        {

        }
    }
}
