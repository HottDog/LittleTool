using Project1.Attribute.TimeStaticTool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute
{
    public class TimeStaticTask : ITask
    {
        public void Run()
        {
            var test = new TimeStaticTestCase();
            test.Test1();
            test.Test2();

        }
    }
}
