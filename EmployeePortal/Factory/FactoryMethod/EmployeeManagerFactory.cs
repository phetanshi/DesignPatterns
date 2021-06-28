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
                    baseEmployee = new PermanentEmployeeFactory(emp);
                    break;
                case 2:
                    baseEmployee = new ContractEmployeeFactory(emp);
                    break;
            }

            return baseEmployee;
        }
    }
}