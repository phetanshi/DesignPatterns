using EmployeePortal.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeTypeId)
        {
            IEmployeeManager employeeManager = null;

            switch (employeeTypeId)
            {
                case 1:
                    return new PermanentEmployeeManager();
                case 2:
                    return new ContractEmployeeManager();
            }

            return employeeManager;
        }
    }
}