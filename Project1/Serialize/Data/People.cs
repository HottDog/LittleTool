using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Serialize.Data
{
    public class People
    {
        private string name;
        public int id;
        public PeopleSerializer serializer;

        public People()
        {
            serializer = new PeopleSerializer(this);
        }

        public People(string n,int i)
        {
            name = n;
            id = i;
            serializer = new PeopleSerializer(this);
        }

        public class PeopleSerializer : Serializer<People>
        {
            public PeopleSerializer(People d) : base(d)
            {
            }

            public override void Serialize(BinaryWriter write)
            {
                write.Write(data.name);
                write.Write(data.id);
            }

            public override bool DeserializeVersionOne(BinaryReader reader)
            {
                data.name = reader.ReadString();
                data.id = reader.ReadInt32();

                Console.WriteLine("People[name:" + data.name + ",id:" + data.id + "]");
                return true;
            }

        }
    }
}
