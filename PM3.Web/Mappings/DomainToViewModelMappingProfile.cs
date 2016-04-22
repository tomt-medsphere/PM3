using AutoMapper;
using PM3.Model.Models;
using PM3.Web.ViewModels;

namespace PM3.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<AccidentCode, AccidentCodeViewModel>();
        }
    }
}