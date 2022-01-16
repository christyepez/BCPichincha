using ApiRestBP.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiRestBP.Repositorio
{
    public interface ICuentaRepositorio
    {
        Task<List<CuentaDto>> GetCuentas();

        Task<CuentaDto> GetCuentaById(int id);

        Task<CuentaDto> CUCuentas(CuentaDto cuentaDto);

        Task<bool> DeleteCuenta(int id);
    }
}
