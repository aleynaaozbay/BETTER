using Better.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better.Entity.Entities
{
    public class Image : BaseEntity
    {
        

        public string FileName { get; set; }

        public string FileType { get; set; }

        public ICollection<Recipe> Recipes { get; set; }


    }
}
