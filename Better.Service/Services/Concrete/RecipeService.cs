using AutoMapper;
using Better.DAL.UnitOfWorks;
using Better.Entity.DTOs.Recipes;
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
        private readonly IMapper mapper;

        public RecipeService(IUnitOfWork unitofWork, IMapper mapper)
        {
            this.unitofWork = unitofWork;
            this.mapper = mapper;
        }

        public async Task<List<RecipeDto>> GetAllRecipesAsync()
        {
            var recipes = await unitofWork.GetRepository<Recipe>().GetAllAsync();
            var map = mapper.Map<List<RecipeDto>>(recipes);

            return map;
        }

      
       

    }
}
