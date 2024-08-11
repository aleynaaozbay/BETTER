using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better.Entity.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public virtual  Guid Id { get; set; }

        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
         

    }
}
