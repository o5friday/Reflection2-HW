using System;

namespace ReflectionConsoleApplication
{
    public class SampleClass
    {
        public event Func<string> SampleEvent;

        public string SampleMethod()
        {
            return "SampleMethod executed";
        }

        public void RaiseEvent()
        {
            if (SampleEvent != null)
            {
                Console.WriteLine(SampleEvent());
            }
        }
    }
}
