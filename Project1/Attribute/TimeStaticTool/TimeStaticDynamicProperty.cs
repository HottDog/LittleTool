using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute.TimeStaticTool
{
    public class TimeStaticDynamicProperty : IContextProperty, IDynamicMessageSink
    {
        public string Name
        {
            get
            {
                return "TimeStatic";
            }
        }

        public void Freeze(Context newContext)
        {
            
        }

        public bool IsNewContextOK(Context newCtx)
        {
            return true;
        }

        public void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync)
        {
            throw new NotImplementedException();
        }

        public void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync)
        {
            throw new NotImplementedException();
        }
    }
}
