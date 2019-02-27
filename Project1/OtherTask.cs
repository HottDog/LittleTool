using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project1 {
    class OtherTask : ITask {
        public void Run()
        {
            //int i = 999999999;
            //Console.Write(i);
            //string s = "i am boy and you are a girl,so we can be together!";
            //s = s.Substring(8);
            //StringBuilder s = new StringBuilder(512);
            //s.AppendFormat("{0,-2}[{1,-20}{2,-30}{3}", "hahaha", "xiaoming", "100", "you du");

            //string s = new string('-',4);
            //OtherTask.GetInt();
            //s.AppendFormat("TreeStuct.AddInfo(\"{0}\", \"{1}\",1);", "FuncA", "ClassA");
            //Console.WriteLine(s);
            Test5();
        }

        public void Test()
        {
            List<int> lists = new List<int>();
            lists.Add(0);
            lists.Add(1);
            lists.Add(2);
            lists.Add(3);
            lists.Add(4);
            lists.Add(5);
            lists.Add(6);
            Console.WriteLine(lists.IndexOf(3));
        }

        public void Test1()
        {
            string s = "hah";
            StringBuilder sb = new StringBuilder(s);
            Console.WriteLine(sb.ToString());
        }

        public void Test2()
        {
            Regex regex = new Regex(@"^Debug\.");
            bool result = regex.IsMatch("Debug.hhaa()");
            //string key = "Debug";
            //string s = "UnityEngine.Debug.hhaa()";
            //string[] ss = s.Split('.');
            //bool result = false;
            //for(int i = 0; i < ss.Length; i++) {
            //    if(key == ss[i]) {
            //        result = true;
            //    }
            //}
            
            
            if (result) {
                string sss = regex.Replace("Debug.hhaa()", "UnityEngine.Debug.");
                Console.WriteLine("匹配成功"+sss);
            }
            else {
                Console.WriteLine("匹配失败");
            }
#if DEBUG
            Console.WriteLine("这是debug模式");
#else
            Console.WriteLine("这是release模式");
#endif
        }

        public void Test3()
        {
            bool ok = true;
            while (ok) {
                Console.Write("插入代码请输入1，删除插入的代码请输入2:");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if(input == '1') {
                    Console.WriteLine("执行插入代码操作。。。");
                    ok = false;
                }else if(input == '2') {
                    Console.WriteLine("执行删除插入代码操作。。。");
                    ok = false;
                }
                else {
                    Console.WriteLine("输入有误，请重新输入！");
                    ok = true;
                }
            }
        }

        public static void GetInt()
        {
            int a = 1;
            if (a == 1)
                throw new Exception();
            Console.WriteLine("can or not come here");
        }    


        private void Test4()
        {
            string s = "effect_002_rgb.png";
            int length = s.LastIndexOf("_rgb");  
            
            Console.WriteLine(s.Substring(0, length)+s.Substring(length+4,s.Length-length-4));
        }

        private void Test5()
        {
            A a = new A();
            B b = new B();
            a.b = b;
            a.b = null;
            if(b == null)
            {
                Console.WriteLine("is null");
            }
            else
            {
                Console.WriteLine("is not null");
            }
            
        }

        public class A
        {
            public B b;
        }

        public class B
        {

        }
    }
}
