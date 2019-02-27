using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace Project1
{
    public class YamlTest : ITask
    {
        public const string path = "D:\\workspace\\c#_workspace\\Project1\\test\\testData1.txt";
        public class TestData1{
            private int a = 0;
            private int b = 0;
            public int c = 0;
            public Dictionary<int, string> list = new Dictionary<int, string>();
            public TestData1()
            {
                a = 1;
                b = 2;
                c = 3;
                list.Add(2, "xiao");
                list.Add(3, "ming");
                list.Add(4, "hha");
            }

            public int A
            {
                get
                {
                    return a;
                }
                set
                {
                    a = value;
                }
            }
        }
        public void Run()
        {
            var deserializer = new Deserializer();
            //Serialize();
            Deserializer();
        }

        public void Serialize()
        {
            StreamWriter streamWriter = new StreamWriter(File.Open(path, FileMode.Truncate));
            var serialize = new Serializer();
            TestData1 test = new TestData1();
            serialize.Serialize(streamWriter,test);
            streamWriter.Close();
        }

        public void Deserializer()
        {
            StreamReader streamReader = new StreamReader(File.Open(path, FileMode.Open));
            var deserializer = new Deserializer();
            TestData1 testData1 = deserializer.Deserialize<TestData1>(streamReader);
            streamReader.Close();
            Console.WriteLine("a:" + testData1.A);

        }
    }
}
