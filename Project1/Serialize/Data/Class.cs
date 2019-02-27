using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Serialize.Data
{
    public class Class
    {
        private Dictionary<int, People> _mPeoples = null;
        private int count = 0;
        private int id;
        public string name;
        public ClassSerializer serializer;

        public Class()
        {
            serializer = new ClassSerializer(this);
            _mPeoples = new Dictionary<int, People>();
            name = "hah";
        }

        public void AddOrUpdatePeople(People p)
        {
            if (_mPeoples.ContainsKey(p.id))
            {
                _mPeoples[p.id] = p;
            }
            else
            {
                _mPeoples.Add(p.id, p);
                count++;
            }
        }

        public void CleanData()
        {
            _mPeoples.Clear();
            count = 0;
        }
        
        public class ClassSerializer : Serializer<Class>
        {
            public ClassSerializer(Class d) : base(d)
            {
            }

            public override void Serialize(BinaryWriter write)
            {
                write.Write(data.name);
                write.Write(data.count);
                foreach(KeyValuePair<int,People> p in data._mPeoples)
                {
                    p.Value.serializer.Serialize(write);
                }
            }

            public override bool DeserializeVersionTwo(BinaryReader reader)
            {
                data.name = reader.ReadString();
                Console.WriteLine("class:[name:"+data.name+"]");
                data.count = reader.ReadInt32();
                for (int i = 0; i < data.count; i++)
                {
                    People people = new People();
                    people.serializer.Deserialize(reader, _mCurVersion);
                    data._mPeoples.Add(people.id, people);
                }
                return true;
            }

            public override bool DeserializeVersionOne(BinaryReader reader)
            {
                data.count = reader.ReadInt32();
                for(int i = 0; i < data.count; i++)
                {
                    People people = new People();
                    people.serializer.Deserialize(reader,_mCurVersion);
                    data._mPeoples.Add(people.id,people);
                }
                return true;
            }
        }



    }
}
