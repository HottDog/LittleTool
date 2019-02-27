using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute.TimeStaticTool
{
    [AttributeUsage(AttributeTargets.Method)]
    public class TimeStaticAttribute:System.Attribute
    {
        public string flag;
        public TimeStaticAttribute(string f)
        {
            flag = f;
        }
    }
}
