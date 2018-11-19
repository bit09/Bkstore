using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Bkstore.Dtos;
using Bkstore.Models;

namespace Bkstore.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            CreateMap<CustomerDto, Customer>();
        }
    }
}