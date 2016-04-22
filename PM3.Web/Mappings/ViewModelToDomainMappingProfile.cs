using AutoMapper;
using PM3.Model.Models;
using PM3.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PM3.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<AccidentCodeFormViewModel, AccidentCode>()
                .ForMember(g => g.AccidentCodeID, map => map.MapFrom(vm => vm.AccidentCodeTitle))
                .ForMember(g => g.Description, map => map.MapFrom(vm => vm.AccidentCodeDescription));
        }
    }
}