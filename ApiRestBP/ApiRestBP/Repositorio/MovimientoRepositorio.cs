using ApiRestBP.Data;
using ApiRestBP.Models;
using ApiRestBP.Models.Dto;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ApiRestBP.Repositorio
{
    public class MovimientoRepositorio : IMovimientoRepositorio
    { 
        private readonly DbBPContext _db;
        private IMapper _mapper;

        public MovimientoRepositorio(DbBPContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<MovimientoDto> CUMovimiento(MovimientoDto movimientoDto)
        {
            Movimiento movimiento = _mapper.Map<MovimientoDto, Movimiento>(movimientoDto);
            if (movimiento.MovimientoId > 0)
            {
                _db.Movimientos.Update(movimiento);
            }
            else
            {
                await _db.Movimientos.AddAsync(movimiento);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Movimiento, MovimientoDto>(movimiento);
        }

        public async Task<bool> DeleteMovimiento(int id)
        {
            try
            {
                Movimiento movimiento = await _db.Movimientos.FindAsync(id);
                if (movimiento == null)
                {
                    return false;
                }
                _db.Movimientos.Remove(movimiento);
                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<List<MovimientoDto>> GetMovimiento()
        {
            List<Movimiento> lista = await _db.Movimientos.ToListAsync();

            return _mapper.Map<List<MovimientoDto>>(lista);
        }

        public async Task<MovimientoDto> GetMovimientoById(int id)
        {
            Movimiento movimiento = await _db.Movimientos.FindAsync(id);

            return _mapper.Map<MovimientoDto>(movimiento);
        }
    }
}
