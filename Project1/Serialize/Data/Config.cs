using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Serialize.Data
{
    public class Config
    {
        public const string NAME = "Class";
        public string name;
        public string version;
        public string newversion;
        private List<Class> _mDatas;
        private int count;
        public ConfigSerializer serializer;

        public Config()
        {
            serializer = new ConfigSerializer(this);
            _mDatas = new List<Class>();
        }

        public void InitDefaultConfig()
        {
            name = NAME;
            version = Serializer<Config>.VERSION_ONE;
        }

        public void AddClass(Class c)
        {
            _mDatas.Add(c);
            count++;
        }

        public class ConfigSerializer : Serializer<Config>
        {
            public ConfigSerializer(Config d) : base(d)
            {
            }

            public override void Serialize(BinaryWriter write)
            {
                write.Write(data.name);
                write.Write(data.count);
                foreach(Class c in data._mDatas)
                {
                    c.serializer.Serialize(write);
                }
            }

            public override bool DeserializeVersionOne(BinaryReader reader)
            {
                data.name = reader.ReadString();
                Console.WriteLine("name:" + data.name);
                data.count = reader.ReadInt32();
                Console.WriteLine("count:" + data.count);
                for(int i = 0; i < data.count; i++)
                {
                    Class c = new Class();
                    c.serializer.Deserialize(reader,data.version);
                    data._mDatas.Add(c);
                }
                return true;
            }
        }
    }
}
