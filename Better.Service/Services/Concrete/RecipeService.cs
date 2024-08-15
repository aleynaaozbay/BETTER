using Better.DAL.UnitOfWorks;
using Better.Entity.Entities;
using Better.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better.Service.Services.Concrete
{
    public class RecipeService : IRecipeService
    {
        private readonly IUnitOfWork unitofWork;

        public RecipeService(IUnitOfWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }

        public async Task<List<Recipe>> GetAllRecipeAsync()
        {
            return await unitofWork.GetRepository<Recipe>().GetAllAsync();
        }
    }
}
