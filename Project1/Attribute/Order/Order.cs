using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Attribute.Order
{
    [CallTrace]
    public class Order:ContextBoundObject
    {
        public int id;
        public string product;
        public int quantity;

        public Order(int quan)
        {
            quantity = quan;
            
        }

        public void Submit(string pro,int quan)
        {
            //product = pro;
            //quantity = quan;
            Console.WriteLine("submit：" + pro + "," + quan);
            Print();
        }

        private void Print()
        {
            Console.WriteLine("print");
        }
    }
}
