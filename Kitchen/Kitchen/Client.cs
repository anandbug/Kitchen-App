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
            String addname, addcode;
            int addquantity;
            while (bl)
            {
                Console.WriteLine("\n This is a menu for user:");
                Console.WriteLine("\n1. Input new purcahsed material\n2. Consume Item\n3. Display\n\n press any other key to Exit\n");
                int check = int.Parse(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        Console.WriteLine("Enter the name of the item: ");
                        addname = Console.ReadLine();
                        Console.WriteLine("Enter the code of the item: ");
                        addcode = Console.ReadLine();
                        Console.WriteLine("Enter the quantity of the item: ");
                        addquantity = int.Parse(Console.ReadLine());
                        stock.AddItem(addname, addcode,addquantity);
                        break;

                    case 2:
                        Console.WriteLine("Enter the code of item: ");
                        String updatecode = Console.ReadLine();
                        Console.WriteLine("Enter the quantity consumed : ");
                        String consumed = Console.ReadLine();
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


