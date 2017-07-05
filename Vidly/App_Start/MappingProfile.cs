using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<CustomerDto, Customer>();
            Mapper.CreateMap<Customer, CustomerDto>();
            CreateMap<Customer, CustomerDto>()
                .ForMember(m => m.Id, opt => opt.Ignore());

            Mapper.CreateMap<MovieDto, Movie>();
            Mapper.CreateMap<Movie, MovieDto>();
            CreateMap<Movie, MovieDto>()
                .ForMember(m => m.Id, opt => opt.Ignore());
        }
    }
}