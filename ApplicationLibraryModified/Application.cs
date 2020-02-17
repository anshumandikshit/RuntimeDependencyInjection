using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ApplicationLibraryModified
{
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

        public async Task Run()
        {
            //AssemblyDependencyLoad();
           await _businessLogic.ProcessData();
        }

        private Type AssemblyDependencyLoad()
        {
            var asb = Assembly.Load("DemoLibrary");
            var type = asb.GetType("IBusinessLogic");
            return type;
        }
    }
}

