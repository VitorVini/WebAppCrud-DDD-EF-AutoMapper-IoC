
using ProjetoDotNetDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDotNetDDD.Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
