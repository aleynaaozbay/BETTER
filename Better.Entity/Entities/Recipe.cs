using Better.Core.Entities;
using Better.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better.Entity.Entities
{
    public class Recipe : BaseEntity, IEntityBase
    {


        public string Title { get; set; }

        public string Materials { get; set; }

        public string Preparation { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; }


        public Guid ImageId { get; set; }

        public Image Image { get; set; }






    }
}
