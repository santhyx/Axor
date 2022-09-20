using Domain.Types;

namespace Domain.Models.ValueObjects
{
    internal class Coordinates : ValueObject<string, Coordinates>
    {
        public double Latitude { get; init; }
        public double Longitude { get; init; }


        public Coordinates(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        protected Coordinates()
        {
        }


        protected override string ToValueConverter()
        {
            throw new NotImplementedException();
        }

        protected override Coordinates? ToObjectConverter(string value)
        {
            throw new NotImplementedException();
        }
    }
}
