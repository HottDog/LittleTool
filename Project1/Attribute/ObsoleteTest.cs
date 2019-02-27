using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute
{
    public class ObsoleteTest
    {
        [Obsolete("这是个被抛弃的旧方法，请使用NewFunc()替代",true)]
        private void OldFunc()
        {    

        }

        private void NewFunc()
        {

        }
          
        [Obsolete("这是个旧方法，请使用NewFunc()替代")]
        private void OldButUseFunc()
        {

        }  

        public void Run()
        {
            //OldFunc();
            //OldButUseFunc();
        }
    }
}
