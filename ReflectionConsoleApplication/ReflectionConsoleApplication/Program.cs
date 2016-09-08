using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = new SampleClass();
            var eventInfo = sample.GetType().GetEvent("SampleEvent");
            var methodInfo = sample.GetType().GetMethod("SampleMethod");
            Delegate handler = Delegate.CreateDelegate(
                eventInfo.EventHandlerType,
                sample,
                methodInfo);
            eventInfo.AddEventHandler(sample, handler);

            sample.RaiseEvent();
            Console.ReadKey();
        }

        
    }
}
