using IFSPStoreDomain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStoreDomain.Entity
{
    public class Sale : BaseEntity<int>
    {
        public Sale(int id, DateTime date, float totalAmount):base(id)
        {
            Date = date;
            TotalAmount = totalAmount;
        }

        public DateTime Date { get; set; }
        public float TotalAmount { get; set; }
    }

    public class ItemSale : BaseEntity<int>
    {
        public ItemSale(int id, int quantity, float unityPrice, float totalAmount) : base(id)
        {
            TotalAmount = totalAmount;
            Quantity = quantity;
            UnityPrice = unityPrice;
        }

        public float TotalAmount { get; set; }
        public int Quantity { get; set; }
        public float UnityPrice { get; set; }
    }

}
