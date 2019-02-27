using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    class MeasureCPUTimeTask : ITask {
        public void Run()
        {
            TestTime(10000, 10000);
            TestTime(1000, 1000);
            TestTime(100, 100);
            TestTime(10, 10);
            TestTime(1, 10000);
        }

        public void TestTime(int iTimes,int jTimes)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[][] a = new int[iTimes][];
            for (int i = 0; i < iTimes; i++) {
                a[i] = new int[jTimes];
                for (int j = 0; j < jTimes; j++) {
                    a[i][j] = i * j;
                }
            }
            sw.Stop();
            TimeSpan ts2 = sw.Elapsed;
            Console.WriteLine("当iTimes={0}，jTimes={1}Stopwatch总共花费{2}ms.", iTimes, jTimes, ts2.TotalMilliseconds);
        }
    }
}
