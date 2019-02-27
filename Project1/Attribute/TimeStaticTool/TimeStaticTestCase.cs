using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute.TimeStaticTool
{
    public class TimeStaticTestCase:TimeStatic
    {
        [TimeStatic("Test1")]
        public void Test1()
        {
            Console.WriteLine("Test1");
        }

        [TimeStatic("Test2")]
        public void Test2()
        {
            Console.WriteLine("Test2");
            Test3();
        }

        [TimeStatic("Test3")]
        private void Test3()
        {
            Console.WriteLine("Test3");
        }
    }
}
