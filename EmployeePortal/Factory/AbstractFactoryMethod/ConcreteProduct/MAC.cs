using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeePortal.Factory.AbstractFactoryMethod.Enumerations;

namespace EmployeePortal.Factory.AbstractFactoryMethod
{
    public class MAC : IBrand
    {
        public string GetBrand()
        {
            return Brands.APPLE.ToString();
        }
    }
}