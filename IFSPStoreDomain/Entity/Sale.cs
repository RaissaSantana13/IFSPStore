using IFSPStoreDomain.Base;
namespace IFSPStoreDomain.Entity
{
    public class Sale : BaseEntity<int>
    {
        public Sale()
        {
            
        }
        public Sale(int id, DateTime saleDate, decimal saleTotal, User salesman, Costumer costumer) : base(id)
        {
            SaleDate = saleDate;
            SaleTotal = saleTotal;
            Salesman = salesman;
            Costumer = costumer;
            SaleItems =new List<SaleItem>();
        }

        public DateTime SaleDate { get; set; }
        public decimal SaleTotal { get; set; }
        public User Salesman { get; set; }
        public Costumer Costumer { get; set; }
        public List<SaleItem> SaleItems { get; set; }
    }

    public class SaleItem : BaseEntity<int>
    {
        public SaleItem()
        {
            
        }
        public SaleItem(int id, decimal quantity, decimal unitPrice, decimal totalPrice, Sale sale, Product product) : base(id)
        {
            Sale = sale;
            Product = product;
            TotalPrice = totalPrice;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }

}
