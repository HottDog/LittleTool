using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    public class StringTask : ITask {
public
void
Run()
        {
            //string s = "123456789";
            //s = s.Insert(0, "yjc");
            //string s = "ha\";\";\";hha";
            //Console.WriteLine((string)s);
            //char[] slist = s.ToCharArray();
            //foreach(char c in slist) {
            //    Console.Write(c + " ");
            //}
            //throw new Exception();
            //Console.WriteLine("这里还能有处理吗");
            string s = "123456789";

            string s1 = s.Insert(3, "yjc");
            Console.WriteLine(s1);
        }
    }
}
