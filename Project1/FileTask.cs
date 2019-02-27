using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1 {
    public class FileTask : ITask {
        private string path = "D:\\test_workspace\\Project1\\1.txt";
        public void Run()
        {
            Stream stream = new FileStream(path,FileMode.Append);
            StreamWriter sw = new StreamWriter(stream, Encoding.UTF8);
            sw.Write("yjc",3);
            
            sw.Close();
            stream.Close();
        }
    }
}
