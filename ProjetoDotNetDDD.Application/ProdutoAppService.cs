
using ProjetoDotNetDDD.Application.Interface;
using ProjetoDotNetDDD.Domain.Entities;
using ProjetoDotNetDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoDotNetDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
