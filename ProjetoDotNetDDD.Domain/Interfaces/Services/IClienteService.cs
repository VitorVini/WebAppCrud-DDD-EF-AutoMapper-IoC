

using ProjetoDotNetDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDotNetDDD.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
