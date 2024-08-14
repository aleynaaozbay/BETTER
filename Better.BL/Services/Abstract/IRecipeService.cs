using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Better.BL.Services.Abstract
{
    public interface IRecipeService
    {
        Task<List<Recipe>> GetAllRecipesAsync();
    }
}
