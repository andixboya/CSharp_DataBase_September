﻿

namespace FastFood.Web.MappingConfiguration
{
    using AutoMapper;
    using FastFood.Models;
    using FastFood.Web.ViewModels.Employees;
    using FastFood.Web.ViewModels.Items;
    using FastFood.Web.ViewModels.Positions;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            this.CreateMap<CreatePositionInputModel, Position>()
                .ForMember(d=> d.Name, s=> s.MapFrom(y=> y.PositionName));
            
            //THIS... FUCKING THING... WHAT A BUG...
            //this.CreateMap<Item, ItemsAllViewModels>()
            //    .ForMember(d => d.Name, s => s.MapFrom(y => y.Category.Name));

        }

    }
}
