using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    using System.Collections;
    using Kitchen;

    public class ItemStock
    {
        List<Item> list = new List<Item>();

        public void AddItem()
        {
            String addname, addcode;
            int addtype;
            decimal addquantity;
            Console.Write("Enter the name of the item: ");
            addname = Console.ReadLine();
            Console.Write("Enter the code of the item: ");
            addcode = Console.ReadLine();
            Console.WriteLine("1. Kilogram\n2. Litres\n3.Dozens\n");
            Console.Write("Enter the quantity type of the item: ");
            addtype = int.Parse(Console.ReadLine());
            switch (addtype)
            {
                case 1: Console.Write("Enter the {0} of {1} of the item: ", UnitOfMesurement.Kgs, addname);
                    addquantity = decimal.Parse(Console.ReadLine());
                    list.Add(new Item(addname, addcode, addquantity, UnitOfMesurement.Kgs));
                    break;

                case 2: Console.Write("Enter the quantity of the item: ", UnitOfMesurement.Ltrs, addname);
                    addquantity = decimal.Parse(Console.ReadLine());
                    list.Add(new Item(addname, addcode, addquantity, UnitOfMesurement.Ltrs));
                    break;

                case 3: Console.Write("Enter the quantity of the item: ", UnitOfMesurement.Dozen, addname);
                    addquantity = decimal.Parse(Console.ReadLine());
                    list.Add(new Item(addname, addcode, addquantity, UnitOfMesurement.Dozen));
                    break;
            }
        }

        public void UpdateItem()
        {
            ItemConsumption consume=new ItemConsumption();
            consume.UpdateItem(list);
        }

        public void display()
        {
            Console.WriteLine("Contents of kitchen are :\n");
            Console.WriteLine(" Name\t\tCode\t\tQuantity\n");
            foreach (Item i in list)
            {
                switch ((int)i.Type)
                {
                    case 1: Console.WriteLine(" {0}\t\t{1}\t\t{2}{3}", i.Name, i.Code, i.Quantity,i.Type);
                        break;
                    case 2: Console.WriteLine(" {0}\t\t{1}\t\t{2}{3}", i.Name, i.Code, i.Quantity,i.Type);
                        break;
                    case 3: Console.WriteLine(" {0}\t\t{1}\t\t{2}{3}", i.Name, i.Code, i.Quantity,i.Type);
                        break;
                }
            }
        }
    }
}
                 