using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Factory.AbstractFactoryMethod
{
    public class MACFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public virtual IProcessor Processor()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    public class MACLaptopFactory : MACFactory
    {
        public override IProcessor Processor()
        {
            return new I7();
        }
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}