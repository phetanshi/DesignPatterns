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
            if (employeeTypeId == 1)
                employeeManager = new PermanentEmployeeManager();
            else if(employeeTypeId == 2)
                employeeManager = new ContractEmployeeManager();

            return employeeManager;
        }
    }
}