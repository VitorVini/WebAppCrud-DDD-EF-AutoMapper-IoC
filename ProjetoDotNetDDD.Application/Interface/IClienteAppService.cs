

using ProjetoDotNetDDD.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoDotNetDDD.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
