using Loja.Business.Models;
using System;
using System.Threading.Tasks;

namespace Loja.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}
