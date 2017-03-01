using AutoMapper;
using Data;
using System.Collections.Generic;
using Test.Web.Models;

namespace Test.Web.Infrastructure.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<PostViewModel, Post>();
            this.CreateMap<Post, PostViewModel>();
        }
    }
}
