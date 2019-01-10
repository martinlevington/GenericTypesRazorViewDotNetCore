using System.Collections.Generic;

namespace GenericTypesRazorViewDotNetCore.Models
{
    public class ItemsViewModel
    {

            public List<IPropertyValue> Values { get; set; } = new List<IPropertyValue>();


            public ItemsViewModel()
            {
                Values.Add(new PropertyValue(3, typeof(int)));
                Values.Add(new PropertyValue(5, typeof(int)));

                Values.Add(new PropertyValue("hi", typeof(string)));
            }
    }
}
