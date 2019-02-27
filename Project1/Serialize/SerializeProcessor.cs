using Project1.Serialize.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Serialize
{
    public class SerializeProcessor
    {
        public const string VERSION = Serializer<SerializeProcessor>.VERSION_TWO;
        public Config config;
        private string _mPath;
        public SerializeProcessor()
        {
            _mPath = "D:/workspace/c#_workspace/Project1/class.config";
            _Init();
        }

        private void _Init()
        {
            try
            {
                config = new Config();
                if (File.Exists(_mPath))
                {
                    BinaryReader reader = new BinaryReader(File.Open(_mPath, FileMode.Open));
                    config.version = reader.ReadString();
                    Console.WriteLine("version:" + config.version);
                    config.serializer.Deserialize(reader,config.version);
                    reader.Close();
                }
                else
                {
                    config.InitDefaultConfig();
                }
            }catch(IOException e)
            {
                Console.WriteLine("读取配置文件失败"+e.Message);          
            }
        }

        public void SaveConfig()
        {
            config.version = VERSION;
            try 
            {
                BinaryWriter write = new BinaryWriter(File.Open(_mPath, FileMode.Create));
                write.Write(config.version);
                config.serializer.Serialize(write);
                write.Close();
            }
            catch(IOException e)
            {
                Console.WriteLine("写入配置文件失败" + e.Message);
            }
        }

    }
}
