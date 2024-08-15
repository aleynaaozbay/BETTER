using AutoMapper;
using Better.Entity.DTOs.Recipes;
using Better.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better.Service.AutoMapper.Recipes
{
    public class RecipeProfile : Profile
    {
        public RecipeProfile() 
        {
            CreateMap<RecipeDto, Recipe>().ReverseMap();


        }
    }
}
