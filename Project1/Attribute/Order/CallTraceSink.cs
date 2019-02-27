using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute.Order
{
    //消息接收器
    public class CallTraceSink : IMessageSink
    {
        private IMessageSink _mNextSink;
        private Order order;

        public CallTraceSink(Object order,IMessageSink next)
        {
            if(order is Order)
            {
                Console.WriteLine("确实获取到了Order对象");
                this.order = order as Order;
            }
            _mNextSink = next;

        }

        public IMessageSink NextSink
        {
            get
            {
                return _mNextSink;
            }
        }

        //方法调用的前置处理
        public void PreProcess(IMessage msg)
        {
            IMethodCallMessage call = msg as IMethodCallMessage;
            if (call == null)
            {
                return;
            }
            if(call.MethodName == "Submit")
            {
                string product = call.GetArg(0).ToString();
                int qty = (int)call.GetArg(1);

                //处理代码
                if (qty > 100)
                {
                    Console.WriteLine("产品"+product+"质量检查通过");
                    
                }
                else
                {
                    Console.WriteLine("产品" + product + "质量检查不通过");
                }
            }
            
        }

        //方法调用完返回结果时的后置处理
        public void PostProcess(IMessage msg,IMessage retMsg)
        {
            IMethodCallMessage call = msg as IMethodCallMessage;
            if(call == null)
            {
                return;
            }
            string product = call.GetArg(0).ToString();
            int qty = (int)call.GetArg(1);
            Console.WriteLine("产品" + product + "的质量是" + qty);
        }

        //异步处理
        public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
        {
            return null;
        }

        //同步处理
        public IMessage SyncProcessMessage(IMessage msg)
        {
            //拦截消息，做前置处理
            PreProcess(msg);
            //传递消息给下一个接收器
            IMessage retMsg = NextSink.SyncProcessMessage(msg);   //在这个过程中oreder具体执行了Submit函数
            //调用返回时进行拦截，并进行后置处理
            PostProcess(msg, retMsg);
            return retMsg;
        }
    }
}
