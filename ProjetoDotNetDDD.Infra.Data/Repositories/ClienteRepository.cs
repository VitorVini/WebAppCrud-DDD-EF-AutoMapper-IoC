using ProjetoDotNetDDD.Domain.Entities;
using ProjetoDotNetDDD.Domain.Interfaces.Repositories;

namespace ProjetoDotNetDDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
    }
}
