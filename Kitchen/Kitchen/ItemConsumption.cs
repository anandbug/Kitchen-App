using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    public delegate void ChangedEventHandler();

    public class ItemConsumption
    {
        public event ChangedEventHandler overflow;

        public void UpdateItem(List<Item> list)
        {
            String updatecode;
            decimal consumed;
            Console.Write("Enter the code of item: ");
            updatecode = Console.ReadLine();
            var updateItem = list.Where(i => i.Code == updatecode).FirstOrDefault();
            switch ((int)updateItem.Type)
            {
                    case 1: Console.Write("Enter the Kilograms consumed : ");
                        break;
                    case 2: Console.Write("Enter the Litres consumed : ");
                        break;
                    case 3: Console.Write("Enter the Dozens consumed : ");
                        break;
            }
            consumed = decimal.Parse(Console.ReadLine());
            if (updateItem.Quantity > consumed)
            {
                updateItem.Quantity -= consumed;
                Console.WriteLine("\n{0} is consumed by {1} and remaining is {2}", updateItem.Name, consumed, updateItem.Quantity);
            }
            else
            {
                overflow+=new ChangedEventHandler(onChanged);
                overflow();
            }
        }
        protected void onChanged()
        {
            Console.WriteLine("\n****No sufficient stock left of the item****");
        }
    }
}
