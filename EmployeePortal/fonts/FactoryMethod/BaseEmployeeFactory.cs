using EmployeePortal.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.fonts.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        public abstract IEmployeeManager Create();
    }
}