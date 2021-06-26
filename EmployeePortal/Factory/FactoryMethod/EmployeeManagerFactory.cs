using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactoy(Employee emp)
        {
            BaseEmployeeFactory baseEmployee = null;

            switch(emp.EmployeeTypeID)
            {
                case 1:
                    return new PermanentEmployeeFactory(emp);
                case 2:
                    return new ContractEmployeeFactory(emp);
            }

            return baseEmployee;
        }
    }
}