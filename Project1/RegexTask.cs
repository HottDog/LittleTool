using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project1 {
    public class RegexTask : ITask {
        public void Run()
        {
            Regex regex = new Regex("[0-9]");
            if (regex.IsMatch("A")) {
                Console.WriteLine("匹配成功");
            }
            else {
                Console.WriteLine("匹配失败");
            }

        }
    }
}
