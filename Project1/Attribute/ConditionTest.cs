#define yjc1

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute
{
    public class ConditionTest
    {
        [Conditional("yjc")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }

    }

    public class Test
    {
        public void Func1()
        {
            ConditionTest.Message("In Func1()");
            Func2();
        }

        private void Func2()
        {
            ConditionTest.Message("In Func2()");
        }

    }
}
