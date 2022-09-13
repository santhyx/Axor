using System;

namespace Domain.Types
{
    public abstract class ValueObject<TValueType, RInstanceType> : EquitableObject<RInstanceType> where RInstanceType : class
    {
        protected abstract TValueType ToValueConverter();
        protected abstract RInstanceType? ToObjectConverter(TValueType value);

        public RInstanceType? ToObject(TValueType value)
        {
            try
            {
                return ToObjectConverter(value);
            }
            catch (Exception ex)
            {
                throw new Exception("Cannot convert from value to object instance", ex);
            }
        }

        public TValueType ToValue()
        {
            try
            {
                return ToValueConverter();
            }
            catch (Exception ex)
            {
                throw new Exception("Cannot convert from object instance to value", ex);
            }
        }
    }
}
