

using AutoMapper;
using ProjetoDotNetDDD.Domain.Entities;
using ProjetoDotNetDDD.MVC.ViewModels;

namespace ProjetoDotNetDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}