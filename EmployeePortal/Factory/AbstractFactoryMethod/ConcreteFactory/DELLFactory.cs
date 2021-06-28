using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.AbstractFactoryMethod
{
    public class DELLFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new DELL();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    public class DELLLaptopFactory : DELLFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}