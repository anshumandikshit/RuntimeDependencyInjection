using Autofac;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using ApplicationLibraryModified;

namespace RuntimeDependencyInjection
{
   public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            try
            {
                LoadDllDynamically();

                //Loading the class Name and Interface Name dynamically from the json file
                //var asb = Assembly.Load("DemoLibrary");
                //var cls = asb.CreateInstance("DemoLibrary.JsonFile");
                //Type type = cls.GetType();
                //var mi = type.InvokeMember("ReadJsonFile", BindingFlags.InvokeMethod, null, cls, new object[] { });
                ////////
                ///
                Console.WriteLine("class instantiated .");



                


                var builder1 = builder.RegisterAssemblyTypes(Assembly.Load("ApplicationLibraryModified"))
                     .Where(t => t.Namespace.Contains("ApplicationLibraryModified"))
                     .As(t => t.GetInterfaces().First(i => i.Name == "I" + t.Name));


                var builder2 = builder.RegisterAssemblyTypes(Assembly.Load("DemoLibrary"))
                      .Where(t => t.Namespace.Contains("Utilities"))
                      .As(t => t.GetInterfaces().First(i => i.Name == "I" + t.Name));

                builder.RegisterType<Application>().As<IApplication>();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            //copying a demoLibrary.dll file from a destination to bin/debug of the actual destination in runtime
            return builder.Build();
        }


        private static void LoadDllDynamically()
        {
            string sourcePath = @"C:\Users\anshumand\Desktop\netcoreapp2.2";
            string destPath = @"C:\Users\anshumand\Documents\Visual Studio 2017\Projects\RuntimeDependencyInjection\RuntimeDependencyInjection\bin\Debug\netcoreapp2.2";

            string sourceFileName = "DemoLibrary.dll";
            string destFileName = "DemoLibrary.dll";

            string fullSourcePath = Path.Combine(sourcePath, sourceFileName);
            string fullDestPath = Path.Combine(destPath, destFileName);

            if (!Directory.Exists(destPath))
                Directory.CreateDirectory(destPath);

            if (!File.Exists(fullDestPath))
                File.Move(fullSourcePath, fullDestPath);


        }
    }
}
