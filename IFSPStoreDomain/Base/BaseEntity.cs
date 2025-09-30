using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStoreDomain.Base
{
    public abstract class BaseEntity<TId> : IBaseEntity
    {
        public BaseEntity(TId id) 
        {
            Id=id;
        }  
        public TId Id { get; set;}
    }
}
