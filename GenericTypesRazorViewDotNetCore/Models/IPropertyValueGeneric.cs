using System;

namespace GenericTypesRazorViewDotNetCore.Models
{
    public interface IPropertyValueGeneric<T>
    {
        T Value { get; set; }
    }
}
