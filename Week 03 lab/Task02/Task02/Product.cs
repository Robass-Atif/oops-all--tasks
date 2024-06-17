using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Product
    {
        public string name;
        public  string category;
        public float price;
        public float stock;
        public float minStock;
        public Product()
        {
            name = "";
            category = "";
            price = 0;
            stock = 0;
            minStock = 0;
        }
        public  Product(string n,string c,int p,int s,int m)
        {
            name = n;
            category = c;
            price = p;
            stock = s;
            minStock =m;
        }
        public  Product(Product obj)
        {
            name = obj.name;
            category = obj.category;
            price = obj.price;
            stock = obj.stock;
            minStock = obj.minStock;
        }
       
        
    }
}
