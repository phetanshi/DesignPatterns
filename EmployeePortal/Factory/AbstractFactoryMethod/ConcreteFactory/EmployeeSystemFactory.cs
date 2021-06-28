using EmployeePortal.Managers;
using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.AbstractFactoryMethod
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee employee)
        {
            IComputerFactory computerFactory = null;

            switch((EmployeeTypeEnum)employee.EmployeeTypeID)
            {
                case EmployeeTypeEnum.Permanent:
                    if(employee.JboDescription.ToLower() == "manager")
                    {
                        computerFactory = new MACLaptopFactory();
                    }
                    else
                    {
                        computerFactory = new MACFactory();
                    }
                    break;
                case EmployeeTypeEnum.Contractor:
                    if (employee.JboDescription.ToLower() == "manager")
                    {
                        computerFactory = new DELLLaptopFactory();
                    }
                    else
                    {
                        computerFactory = new DELLFactory();
                    }
                    break;
            }

            return computerFactory;
        }
    }
}