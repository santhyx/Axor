using Domain.Types;

namespace Domain.Models.ValueObjects
{
    internal record Coordinates
    {
        public double Latitude { get; init; }
        public double Longitude { get; init; }

        public Coordinates(long latitude, long longitude)
        {

        }
    }
}
