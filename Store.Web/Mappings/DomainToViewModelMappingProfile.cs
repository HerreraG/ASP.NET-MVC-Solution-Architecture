﻿using AutoMapper;
using Store.Model;
using Store.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Web.Mappings {
    public class DomainToViewModelMappingProfile : Profile {

        public DomainToViewModelMappingProfile() : base("DomainToViewModelMappings") {
        }

        protected override void Configure() {
            Mapper.CreateMap<Category, CategoryViewModel>();
            Mapper.CreateMap<Gadget, GadgetViewModel>();
        }
    }
}