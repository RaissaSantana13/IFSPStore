using IFSPStoreDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStoreDomain.Entity
{
    public class Product : BaseEntity<int>
    {
        public Product(int id, string name, float price, int quantity, DateTime dateShop, string location) :base(id) 
        { 
            Name=name;
            Price =price;   
            Quantity =quantity; 
            DateShop= dateShop;
            Location =location;
        }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public DateTime DateShop { get; set; }
        public string Location { get; set; }
            
    }
}
