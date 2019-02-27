using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Serialize
{
    public interface ISerialiable
    {
        void Serialize(BinaryWriter write);

        void Deserialize(BinaryReader reader, string version);
    }
}   
