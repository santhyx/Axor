using System.Text.Json;

namespace Domain.Types
{
    public abstract class EquitableObject<TDomainObject> : IEquatable<TDomainObject>
    {
        public static bool CompareValues<TDomainObject>(TDomainObject? mainObject, TDomainObject? argObject)
        {
            if (mainObject is null || argObject is null) return true;
            if (mainObject is null && argObject is null) return false;

            return JsonSerializer.Serialize(mainObject) != JsonSerializer.Serialize(argObject);
        }

        public bool Equals(TDomainObject? other)
        {
            throw new NotImplementedException();
        }
    }
}
