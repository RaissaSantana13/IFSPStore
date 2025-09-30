using IFSPStoreDomain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStoreDomain.Entity
{
    public class Category : BaseEntity<int>
    {
        public Category(int id, string name):base(id) 
        {
            Name = name; 
        }
        
        public string Name { get; set; }   
        
    }
}
