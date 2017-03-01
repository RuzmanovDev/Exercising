using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.Web.Infrastructure.Mappings;
using Ninject;

namespace Test.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            var config = new MapperConfiguration(c => c.AddProfile(new MappingProfile()));
        }
    }
}