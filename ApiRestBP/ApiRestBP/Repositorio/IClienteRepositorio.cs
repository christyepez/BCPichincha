using ApiRestBP.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiRestBP.Repositorio
{
    public interface IClienteRepositorio
    {
        Task<List<ClienteDto>> GetClientes();

        Task<ClienteDto> GetClienteById(int id);

        Task<ClienteDto> CUpdateCliente(ClienteDto clienteDto);

        Task<bool> DeleteCliente(int id);
    }
}
