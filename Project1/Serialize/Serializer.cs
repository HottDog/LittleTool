using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 版本更替的规则：
/// 写入数据的话，不管是什么版本都是以最新的版本进行写入
/// 读取数据的话，
/// 1、如果有对应版本就用对应版本的函数读取数据，
/// 2、如果没有对应版本的函数，则往下降一个版本查找对应版本的函数，
///     直到找到一个对应版本函数进行读写数据
/// </summary>
namespace Project1.Serialize
{
    public abstract class Serializer<T> : ISerialiable
    {
        public enum Version
        {
            ERROR = 0,
            ONE = ERROR+1,
            TWO = ONE + 1,
            THREE = TWO + 1,
            FOUR = THREE + 1       
        }
        public const string VERSION_ONE = "1";
        public const string VERSION_TWO = "2";
        public const string VERSION_THREE = "3";
        public const string VERSION_FOUR = "4";
        //private SerializeManage _mManager;

        private delegate bool DeserializeVersion(BinaryReader reader);
        protected T data;
        protected string _mCurVersion;

        public Serializer(T d)
        {
            data = d;
        }

        public string version
        {
            get
            {
                return _mCurVersion;
            }
            set
            {
                _mCurVersion = value;
            }
        }

        public virtual void Serialize(BinaryWriter write)
        {

        }

        public void Deserialize(BinaryReader reader, string ver)
        {
            _mCurVersion = ver;
            Version curVersion = _GetVersion(ver);
            Console.WriteLine("当前读取函数的版本：" + (int)curVersion);
            while ((int)curVersion > (int)Version.ERROR)
            {
                if(_GetDeserizlizeFunc(curVersion)(reader))
                {
                    return;
                }
                curVersion--;
            }
            throw new Exception("反序列化失败");
        }        

        private Version _GetVersion(string version)
        {
            switch (version)
            {
                case VERSION_ONE:
                    return Version.ONE;
                case VERSION_TWO:
                    return Version.TWO;
                case VERSION_THREE:
                    return Version.THREE;
                case VERSION_FOUR:
                    return Version.FOUR;
            }
            throw new Exception("找不到相应的版本");
        }
        private DeserializeVersion _GetDeserizlizeFunc(Version version)
        {
            switch (version)
            {
                case Version.ONE:
                    return DeserializeVersionOne;
                case Version.TWO:
                    return DeserializeVersionTwo;
                case Version.THREE:
                    return DeserializeVersionThree;
                case Version.FOUR:
                    return DeserializeVersionFour;
                default:
                    return DeserializeVersionOne;
            }
        }

        public virtual bool DeserializeVersionOne(BinaryReader reader)
        {
            return false;
        }

        public virtual bool DeserializeVersionTwo(BinaryReader reader)
        {
            return false;
        }

        public virtual bool DeserializeVersionThree(BinaryReader reader)
        {
            return false;
        }

        public virtual bool DeserializeVersionFour(BinaryReader reader)
        {
            return false;
        }

    }
}
