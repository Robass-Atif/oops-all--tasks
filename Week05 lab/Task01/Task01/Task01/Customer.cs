using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Customer
    {
        public string name;
        public string address;
        public string contact;
        public List<Product> purchase = new List<Product>();
        public List<Product> getAllProduct()
        {

            return purchase;
        }
        public void addProduct(Product p)
        {
            purchase.Add(p);
        }
        
    }
}
