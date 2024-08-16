using System.Reflection;

namespace DemoLib
{
    public class Demo
    {
        public static void Trace()
        {
            Console.WriteLine("Training...");
            Console.WriteLine($"Executing Assembly: {Assembly.GetExecutingAssembly()}");
            Console.WriteLine($"Entry Assembly: {Assembly.GetEntryAssembly()}");
            Console.WriteLine($"Caling Assembly: {Assembly.GetCallingAssembly()}");
           

        }
    }
}
