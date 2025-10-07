using IFSPStoreDomain.Base;

namespace IFSPStoreDomain.Entity
{
    public class Product : BaseEntity<int>
    {
        public Product()
        {
            
        }
        public Product(int id, string name, float price, decimal quantity, string salesUnit,  DateTime purchaseDate, string location, Category categories) :base(id) 
        { 
            Name=name;
            Price =price;   
            Quantity =quantity; 
            SalesUnit = salesUnit;
            PurchaseDate = purchaseDate;
            Location =location;
            Categories =categories;
        }
        public string Name { get; set; }
        public float Price { get; set; }
        public decimal Quantity { get; set; }
        public string SalesUnit { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Location { get; set; }
        public Category Categories { get; set; }
            
    }
}
