using System;

namespace GenericTypesRazorViewDotNetCore.Models
{
    public class PropertyValueInt : IPropertyValueGeneric<int>
    {

        public PropertyValueInt(int value)
        {
            Value = value;
        }


        public int Value { get; set; }
     
        public int GetValue()
        {
            return (int) Value;
        }

    }
}
