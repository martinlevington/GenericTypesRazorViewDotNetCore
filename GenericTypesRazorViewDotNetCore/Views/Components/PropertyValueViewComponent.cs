using System;
using GenericTypesRazorViewDotNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericTypesRazorViewDotNetCore.Views.Components
{
    public class PropertyValueViewComponent : ViewComponent
    {

        public IViewComponentResult Invoke(object propertyValue, Type propertyType)
        {

            switch (propertyType.ToString())
            {
                case "System.Int32":
                    return View("propertyValue", new PropertyValueInt((int) propertyValue));
                case "System.String":
                    return View("propertyValueString",  new PropertyValueString((string) propertyValue));

            }

            return View();

        }

    }
}
