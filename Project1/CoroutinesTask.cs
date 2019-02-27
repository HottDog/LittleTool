using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    public class A : IEnumerable {
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < 10; i++) {
                if (i == 8) {
                    yield break ;
                }
            }
            Console.WriteLine("yield return can go to here?");
        }
    }
    public class CoroutinesTask : ITask {
        public void Run()
        {
            A a = new A();
            a.GetEnumerator();
        }
    }
}
