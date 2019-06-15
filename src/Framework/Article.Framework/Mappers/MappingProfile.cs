using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Article.Framework.Data.Entities;
using Article.Framework.Domain;


namespace Article.Framework.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoriesRecursive>().ForMember(dest => dest.CategoryId, opt => opt.MapFrom(o => o.CategoryId));
        }
    }
}
