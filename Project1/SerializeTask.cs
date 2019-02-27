using Project1.Serialize;
using Project1.Serialize.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class SerializeTask : ITask
    {
        public void Run1()
        {
            SerializeProcessor processor = new SerializeProcessor();
            Class c = new Class();
            c.name = "23";
            c.AddOrUpdatePeople(new People("xiaoming", 1));
            c.AddOrUpdatePeople(new People("haha", 2));
            c.AddOrUpdatePeople(new People("xiaoli", 3));
            processor.config.AddClass(c);
            processor.SaveConfig();
        }

        public void Run()
        {
            string path = "D:\\ss\\ss\\ss";
            path = path.Replace("\\","/    ");
            Console.WriteLine(path);
        }
    }
}
