using DemoLib;
using System.Reflection;

namespace CAAssemblies
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*var type = typeof(Employee);
            var assembly = type.Assembly;
            Console.WriteLine(assembly.FullName);*/
            /*var assembly= Assembly.GetExecutingAssembly();
              Console.WriteLine(assembly.FullName);
           Console.WriteLine(typeof(DateTime).Assembly.FullName);*/
            // Console.WriteLine(assembly.FullName);
           // Demo.Trace();
           var type = typeof(Program);
            var assembly = type.Assembly;
          /* //3 Console.WriteLine($" Assembly Full Name: {assembly.FullName}");
            Cosole.WriteLine($" Location Full Name: {assembly.Location}");
            var assemblyName  = assembly.GetName();
            Console.WriteLine($"Name: {assemblyName.Name}");
            Console.WriteLine($"Version: {assemblyName.Version}");
            Console.WriteLine($"Total Key Tokens length: {assemblyName.GetPublicKeyToken()}");
            Console.WriteLine($"Code: {assemblyName.CodeBase}");
            Console.WriteLine($"DateTime Assembly Name: {typeof(DateTime).Assembly.GetName().Name}");*/
        }
    }
    class Employee
    {

    }
}