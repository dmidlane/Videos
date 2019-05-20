using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Videos.Models;
using Videos.Dtos;

namespace Videos.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domin to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            //Dto to Domain
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}

