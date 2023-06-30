﻿

using AutoMapper;
using ProjetoDotNetDDD.Domain.Entities;
using ProjetoDotNetDDD.MVC.ViewModels;

namespace ProjetoDotNetDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>(); 
        }
    }
}