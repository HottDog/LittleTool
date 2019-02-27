using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute.TimeStaticTool
{
    public class ReflectionUtil
    {
        public static T GetAttribute<T>(MethodInfo method)where T : System.Attribute
        {
            var attr = method.GetCustomAttributes(typeof(T), false);
            if (attr.Length != 0)
            {
                T attribute = attr[0] as T;
                if (attribute != null)
                {
                    return attribute;
                }
            }
            return null;
        }
    }
}
