using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    public class ReturnTask : ITask {
        public void Run()
        {
            try {
                ReturnTask task = null;
                task.Run();
            }catch(Exception e) {
                
            }
            
            Console.WriteLine("能跑到这里吗");
        }
    }
}
