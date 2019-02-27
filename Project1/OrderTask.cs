using Project1.Attribute.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class OrderTask : ITask
    {
        public void Run()
        {
            Order order1 = new Order(100);
            order1.Submit("item1", 50);

            Order order2 = new Order(500);
            order2.Submit("item2", 150);
            
        }
    }
}
