using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    public class Item
    {   
        public Item(string name, string code,decimal quantity,UnitOfMesurement type)
        {
            this.Name = name;
            this.Code = code;
            this.Quantity = quantity;
            this.Type = type;
        }

        public string Name { get; set; }

        public string Code { get; private set; }

        public decimal Quantity { get; set; }

        public UnitOfMesurement Type { get; private set; }
    }

    public enum UnitOfMesurement
    {
        Kgs = 1,
        Ltrs,
        Dozen
    }
}
