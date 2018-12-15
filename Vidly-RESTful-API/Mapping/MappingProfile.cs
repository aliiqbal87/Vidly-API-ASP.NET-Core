﻿using AutoMapper;
using Vidly_RESTful_API.Dtos;
using Vidly_RESTful_API.Models;

namespace Vidly_RESTful_API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to API Resource
            CreateMap<Customer, CustomerDto>();
            CreateMap<Genre, GenreDto>();

            // API Resource to Domain
            CreateMap<CustomerForCreationDto, Customer>();
            CreateMap<CustomerForUpdateDto, Customer>();
            CreateMap<GenreForCreationDto, Genre>();
            CreateMap<GenreForUpdateDto, Genre>();
        }
    }
}