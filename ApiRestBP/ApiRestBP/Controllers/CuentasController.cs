using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ApiRestBP.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiRestBP.Models;
using System.Linq;
using ApiRestBP.Repositorio;
using ApiRestBP.Models.Dto;
using System;
using Microsoft.AspNetCore.Authorization;

namespace ApiRestBP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Authorize]
    public class CuentasController : ControllerBase
    {

        private readonly ICuentaRepositorio _cuentaRepositorio;
        protected ResponseDto _response;

        public CuentasController(ICuentaRepositorio cuentaRepositorio)
        {
            _cuentaRepositorio = cuentaRepositorio;
            _response = new ResponseDto();
        }


        // GET: api/Cuentas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cuenta>>> GetCuentas()
        {
            try
            {
                var lista = await _cuentaRepositorio.GetCuentas();
                _response.Result = lista;
                _response.DisplayMessage = "Lista de Cuentas";
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }

            return Ok(_response);
        }

        // GET: api/Cuentas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cuenta>> GetCuenta(int id)
        {
            var cuenta = await _cuentaRepositorio.GetCuentaById(id);
            if (cuenta == null)
            {
                _response.IsSuccess = false;
                _response.DisplayMessage = "Cuenta No Existe";
                return NotFound(_response);
            }
            _response.Result = cuenta;
            _response.DisplayMessage = "Informacion del Cuenta";
            return Ok(_response);
        }

        // PUT: api/Cuentas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuenta(int id, CuentaDto cuentaDto)
        {
            try
            {
                CuentaDto model = await _cuentaRepositorio.CUCuentas(cuentaDto);
                _response.Result = model;
                return Ok(_response);
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.DisplayMessage = "Error al Actualizar el Registro";
                _response.ErrorMessages = new List<string> { ex.ToString() };
                return BadRequest(_response);
            }
        }

        // POST: api/Cuentas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cuenta>> PostCuenta(CuentaDto cuentaDto)
        {
            try
            {
                CuentaDto model = await _cuentaRepositorio.CUCuentas(cuentaDto);
                _response.Result = model;
                return CreatedAtAction("GetCuenta", new { id = model.CuentaId }, _response);
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.DisplayMessage = "Error al Grabar el Registro";
                _response.ErrorMessages = new List<string> { ex.ToString() };
                return BadRequest(_response);
            }

        }

        // DELETE: api/Cuentas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCuenta(int id)
        {
            try
            {
                bool estaEliminado = await _cuentaRepositorio.DeleteCuenta(id);
                if (estaEliminado)
                {
                    _response.Result = estaEliminado;
                    _response.DisplayMessage = "Cuenta Eliminado con Exito";
                    return Ok(_response);
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.DisplayMessage = "Error al Eliminar Cuenta";
                    return BadRequest(_response);
                }
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
                return BadRequest(_response);
            }
        }


    }
}
