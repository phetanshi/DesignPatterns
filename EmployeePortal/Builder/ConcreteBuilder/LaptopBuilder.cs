using EmployeePortal.Builder.IBuilder;
using EmployeePortal.Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.Builder.ConcreteBuilder
{
    public class LaptopBuilder : ISystemBuilder
    {
        ComputerSystem laptop = new ComputerSystem();
        public ISystemBuilder AddDrive(string size)
        {
            laptop.HDDSize = size;
            return this;
        }

        public ISystemBuilder AddMemory(string memory)
        {
            laptop.RAM = memory;
            return this;
        }
        public ISystemBuilder AddKeyBoard(string type)
        {
            return this;
        }
        public ISystemBuilder AddMouse(string type)
        {
            return this;
        }

        public ISystemBuilder AddTouchScreen(string enabled)
        {
            laptop.TouchScreen = enabled;
            return this;
        }

        public ComputerSystem GetSystem()
        {
            return laptop;
        }
    }
}