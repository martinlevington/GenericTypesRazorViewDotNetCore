using System;

namespace GenericTypesRazorViewDotNetCore.Models
{
    public class PropertyValueString : IPropertyValueGeneric<string>
    {

        public PropertyValueString(string value)
        {
            Value = value;
        }

        public string Value { get; set; }
     

        public string GetValue()
        {
            return Value;
        }

       
    }
}
