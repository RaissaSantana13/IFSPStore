using IFSPStoreDomain.Base;
using System.Globalization;

namespace IFSPStoreDomain.Entity
{
    public class Category : BaseEntity<int>
    {
        public Category()
        {
            
        }
        public Category(int id, string name, string description) :base(id) 
        {
            Name = name;
            Description = description;
        }
        
        public string Name { get; set; }   
        public string Description { get; set; }
        
    }
}
