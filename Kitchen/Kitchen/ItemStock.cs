using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    using System.Collections;
    class ItemStock
    {
        private int Quantity;

        ArrayList list = new ArrayList();

        public void AddItem(String name,String code,int quantity)
        {
            list.Add(new Item(name,code,quantity));
        }

        public void display()
        {
            Console.WriteLine("Contents of kitchen are :\n");
            Console.WriteLine(" Name\t\tCode\t\tQuantity\n");
            foreach (Item i in list)
            {
                Console.WriteLine(" {0}\t\t{1}\t\t{2}", i.name, i.code,i.quantity);
            }
        }
    }
}
