

using ProjetoDotNetDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDotNetDDD.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
