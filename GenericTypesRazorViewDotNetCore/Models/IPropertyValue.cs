using System;

namespace GenericTypesRazorViewDotNetCore.Models
{
    public interface IPropertyValue
    {
        Object Value { get; set; }

        Type TypeValue { get; set; }

        Type GetValueType();
    }
}
