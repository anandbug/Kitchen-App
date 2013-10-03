using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    using Kitchen;
    class Client
    {
        static void Main()
        {
            ItemStock stock = new ItemStock();
            bool bl = true;
            while (bl)
            {
                Console.WriteLine("\n This is a menu for user:");
                Console.WriteLine("\n1. Input new purcahsed material\n2. Consume Item\n3. Display\n\n press any other key to Exit\n");
                int check = int.Parse(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        stock.AddItem();
                        break;

                    case 2:
                        stock.UpdateItem();
                        break;

                    case 3:
                        stock.display();
                        break;

                    default:
                        bl=false;
                        break;
                }
            }   
        }
    }
}


