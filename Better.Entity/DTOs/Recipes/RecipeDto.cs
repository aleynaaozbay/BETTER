using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better.Entity.DTOs.Recipes
{
    public class RecipeDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Materials { get; set; }

        public string Preparation { get; set; }

        public DateTime CreatedDate { get; set; }



    }
}
