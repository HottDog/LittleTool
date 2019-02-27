using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    class Program {
        static void Main(string[] args)
        {
            ITask task = null;
            task = new Task1();

            //task = new OtherTask();
            //task = new FileTask();
            //task = new StringTask();
            //task = new CoroutinesTask();
            //task = new RegexTask();
            //task = new InterfaceTask();
            //task = new ReturnTask();
            //task = new AttributeTask();
            //task = new RefactorTask();
            //task = new SerializeTask();
            //task = new YamlTest();
            task = new OrderTask();
            task.Run();
            Console.ReadKey();
        }
    }
}
