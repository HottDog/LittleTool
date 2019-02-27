using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute.Order
{
    //上下文环境的属性
    public class CallTraceProperty : IContextProperty, IContributeObjectSink
    {

        public CallTraceProperty()
        {

        }

        public string Name
        {
            get
            {
                return "OrderTrace";
            }
        }

        public void Freeze(Context newContext)
        {
            //throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="nextSink">submit里面的调用链接收器</param>
        /// <returns></returns>
        public IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink)
        {
            return new CallTraceSink(obj,nextSink);
        }

        public bool IsNewContextOK(Context newCtx)
        {
            return true;
        }
    }
}
