using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    public class Task1 : ITask {
        public class B
        {
            public A ca;
        }
        public class A
        {
            public int a;
        }

        public void Run()
        {
            A a = new A();
            a.a = 1;
            A b = a;
            //b.a = 2;
            A c = new A();
            c.a = 3;
            a = c;   
            Console.WriteLine(b.a);
        }

        public void Run2()
        {
            A a = new A();
            a.a = 2;
            B b = new B();
            b.ca = a;
            a.a = 4;
            Console.WriteLine(b.ca.a);
        }

        public void Run1()
        {
            int m1 = 10;
            for (int i = 0; i < 10; i++) {
                if (m1 == 10) {
                    if (i == 4)
                        break;
                }

                Console.Write(i + " ");
            }
            Console.WriteLine();
            int m2 = 20;
            for (int i = 0; i < 10; i++) {
                if (m2 == 20) {
                    if (i == 6)
                        break;
                }
                Console.Write(i + " ");

            }
        }
        public void Run3()
        {
            List<int> datas = new List<int>();
            datas.Add(2);
            datas.Add(6);
            datas.Add(1);
            datas.Add(2);
            datas.Add(5);
            datas.Add(2);
            datas.Sort(1,3,new IntCompare());
            foreach(int v in datas)
            {
                Console.Write(v + " ");   
            }
        }

        public class IntCompare : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x >    y)
                {     
                    return -1;
                }else if (x == y)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
