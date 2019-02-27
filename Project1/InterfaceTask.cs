using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    public class InterfaceTask : ITask {

        public interface Listener {
            void OnListener();
        }
        public class ListenerA : Listener {
            public void OnListener()
            {
                Console.WriteLine("A");
            }
        }
        public class ListenerB : Listener {
            public void OnListener()
            {
                Console.WriteLine("B");
            }
        }
        public void Run()
        {
            Listener listener = new ListenerA();
            Change(listener);
            listener.OnListener();
        }
        public void Change(Listener listener)
        {
            listener = new ListenerB();
        }
    }
}
