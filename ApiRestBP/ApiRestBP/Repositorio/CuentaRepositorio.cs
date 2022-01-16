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

    public class CuentaRepositorio : ICuentaRepositorio
    {
        private readonly DbBPContext _db;
        private IMapper _mapper;

        public CuentaRepositorio(DbBPContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<CuentaDto> CUCuentas(CuentaDto cuentaDto)
        {
            Cuenta cuenta = _mapper.Map<CuentaDto, Cuenta>(cuentaDto);
            if (cuenta.CuentaId > 0)
            {
                _db.Cuentas.Update(cuenta);
            }
            else
            {
                await _db.Cuentas.AddAsync(cuenta);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Cuenta, CuentaDto>(cuenta);
        }

        public async Task<bool> DeleteCuenta(int id)
        {
            try
            {
                Cuenta cuenta = await _db.Cuentas.FindAsync(id);
                if (cuenta == null)
                {
                    return false;
                }
                _db.Cuentas.Remove(cuenta);
                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<CuentaDto> GetCuentaById(int id)
        {
            Cuenta cuenta = await _db.Cuentas.FindAsync(id);

            return _mapper.Map<CuentaDto>(cuenta);
        }

        public async Task<List<CuentaDto>> GetCuentas()
        {
            List<Cuenta> lista = await _db.Cuentas.ToListAsync();

            return _mapper.Map<List<CuentaDto>>(lista);
        }
    }
}
