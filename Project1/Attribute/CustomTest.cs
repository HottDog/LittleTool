using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute
{
    public class CustomTest
    {
        [AttributeUsage(AttributeTargets.Class|AttributeTargets.Constructor|
            AttributeTargets.Field|AttributeTargets.Method|AttributeTargets.Property,
            AllowMultiple = true)]
        public class DebugInfo : System.Attribute
        {
            public int id;
            public string developer;
            public string lastReview;
            public string msg;

            public DebugInfo(int i, string d, string l, string m)
            {
                id = i;
                developer = d;
                lastReview = l;
                msg = m;
            }
        }

        [DebugInfo(1,"xiaoming","10/19","我来过")]
        public class Test1
        {
            [DebugInfo(2,"xiaohua","10/22","这是我改的")]
            public int a = 0;
            [DebugInfo(5,"xiaoming","10/22","这不是我改的")]
            public Test1()
            {
                
                a = 1;
            }

            [DebugInfo(5,"xiaohua","10/22","这是我改的")]
            public int A
            {
                get
                {
                    return a;
                }
                set
                {
                    a = value;
                }
            }

            [DebugInfo(3,"huahua","2019年2月25日14:24:03","加个函数")]
            public void Run1()
            {
                Console.WriteLine("a=" + a);
            }



               
        }
    }
}
