﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute.TimeStaticTool
{
    public class TimeStaticClientContextProperty : IContextProperty, IContributeClientContextSink
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

        public IMessageSink GetClientContextSink(IMessageSink nextSink)
        {
            return new TimeStaticSink(nextSink);
        }

        public bool IsNewContextOK(Context newCtx)
        {
            return true;
        }
    }
}
