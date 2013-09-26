using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    public class Item
    {
        private String Name;

        private String Code;

        private int Quantity;

        public Item(String name, String code,int quantity)
        {
            this.Name = name;
            this.Code = code;
            this.Quantity = quantity;
        }
        public String name
        {
            get
            {
                return Name;
            }
        }
        public String code
        {
            get
            {
                return Code;
            }
        }
        public int quantity
        {
            get
            {
                return Quantity;
            }
        }
    }
}
