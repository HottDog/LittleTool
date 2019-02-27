using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute.TimeStaticTool
{
    public class TimeStaticSink : IMessageSink
    {
        private IMessageSink _mNextSink;

        public TimeStaticSink(IMessageSink next)
        {
            _mNextSink = next;
        }

        public IMessageSink NextSink
        {
            get
            {
                return _mNextSink;
            }
        }

        //前置处理
        private void PreProcess(IMessage msg)
        {

        }

        //后置处理
        private void PostProcess(IMessage msg,IMessage retMsg)
        {

        }

        //异步处理
        public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
        {
            return null;
        }

        //同步处理
        public IMessage SyncProcessMessage(IMessage msg)
        {
            IMessage retMsg = null;
            IMethodCallMessage call = msg as IMethodCallMessage;

            if(call != null)
            {
                var attr = ReflectionUtil.GetAttribute<TimeStaticAttribute>(call.MethodBase as MethodInfo);
                if (attr != null)
                {
                    //拦截消息，做前置处理
                    PreProcess(msg);
                    //运行时间统计
                    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                    sw.Start();
                    //传递消息给下一个接收器
                    retMsg = NextSink.SyncProcessMessage(msg);

                    sw.Stop();
                    double totalTime = sw.Elapsed.TotalMilliseconds;
                    totalTime /= 1000;
                    Console.WriteLine("步骤[" + attr.flag + "]使用时间：" + totalTime + "s");

                    //调用返回时进行拦截，并进行后置处理
                    PostProcess(msg, retMsg);
                    return retMsg;
                }
            }
            //传递消息给下一个接收器
            retMsg = NextSink.SyncProcessMessage(msg);
            return retMsg;
        }
    }
}
