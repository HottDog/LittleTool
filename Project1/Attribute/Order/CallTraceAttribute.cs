using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute.Order
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CallTraceAttribute:ContextAttribute
    {
        public CallTraceAttribute():base("CallTrace")
        {

        }

        public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
        {
            ctorMsg.ContextProperties.Add(new CallTraceProperty());
        }
    }
}
