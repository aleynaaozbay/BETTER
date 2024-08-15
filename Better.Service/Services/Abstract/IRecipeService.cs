using Better.Entity.DTOs.Recipes;
using Better.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better.Service.Services.Abstract
{
    public interface IRecipeService
    {
        Task<List<RecipeDto>> GetAllRecipesAsync();

    }
}
