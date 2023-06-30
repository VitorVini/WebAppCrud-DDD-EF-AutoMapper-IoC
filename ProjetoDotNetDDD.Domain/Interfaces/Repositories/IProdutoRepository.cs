
using ProjetoDotNetDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDotNetDDD.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
