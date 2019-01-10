using System;

namespace GenericTypesRazorViewDotNetCore.Models
{
    public class PropertyValue : IPropertyValue
    {


        public object Value { get; set; }
        public Type TypeValue { get; set; }

        public PropertyValue(object value, Type typeValue)
        {
            Value = value;
            TypeValue = typeValue;
        }


        public  Type GetValueType()
        {
            return typeof(int);
        }
    }
}
