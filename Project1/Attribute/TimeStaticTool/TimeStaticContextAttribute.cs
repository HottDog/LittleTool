using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute.TimeStaticTool
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TimeStaticContextAttribute:ContextAttribute
    {
        public TimeStaticContextAttribute() : base("TimeStaticContext")
        {

        }

        public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
        {
            ctorMsg.ContextProperties.Add(new TimeStaticProperty());
            //ctorMsg.ContextProperties.Add(new TimeStaticClientContextProperty());
            //ctorMsg.ContextProperties.Add(new TimeStaticEnvoyPropery());
        }
    }
}
