using ApiRestBP.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ApiRestBP.Repositorio
{
    public interface IMovimientoRepositorio
    {
        Task<List<MovimientoDto>> GetMovimiento();

        Task<MovimientoDto> GetMovimientoById(int id);

        Task<MovimientoDto> CUMovimiento(MovimientoDto movimientoDto);

        Task<bool> DeleteMovimiento(int id);
    }
}
