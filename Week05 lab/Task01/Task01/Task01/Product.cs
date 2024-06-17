using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Product
    {
        public string name;
        public string category;
        public float price;
        public float calculate_tax()
        {
            float tax;
            tax =( price * 0.1f);
            return tax;
        }
    }
}
