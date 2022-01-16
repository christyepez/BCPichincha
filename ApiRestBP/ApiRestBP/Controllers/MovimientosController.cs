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
  //  [Authorize]
    public class MovimientosController : ControllerBase
    {
        private readonly IMovimientoRepositorio _movimientoRepositorio;
        protected ResponseDto _response;

        public MovimientosController(IMovimientoRepositorio clienteRepositorio)
        {
            _movimientoRepositorio = clienteRepositorio;
            _response = new ResponseDto();
        }
        // GET: api/Movimiento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movimiento>>> GetMovimientos()
        {
            try
            {
                var lista = await _movimientoRepositorio.GetMovimiento();
                _response.Result = lista;
                _response.DisplayMessage = "Lista de Movimientos";
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string> { ex.ToString() };
            }

            return Ok(_response);
        }

        // GET: api/Movimiento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Movimiento>> GetMovimiento(int id)
        {
            var movimiento = await _movimientoRepositorio.GetMovimientoById(id);
            if (movimiento == null)
            {
                _response.IsSuccess = false;
                _response.DisplayMessage = "Movimiento No Existe";
                return NotFound(_response);
            }
            _response.Result = movimiento;
            _response.DisplayMessage = "Informacion del Movimiento";
            return Ok(_response);
        }

        // PUT: api/Movimiento/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovimiento(int id, MovimientoDto movimientoDto)
        {
            try
            {
                MovimientoDto model = await _movimientoRepositorio.CUMovimiento(movimientoDto);
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

        // POST: api/Movimiento
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Movimiento>> PostMovimiento(MovimientoDto movimientoDto)
        {
            try
            {
                MovimientoDto model = await _movimientoRepositorio.CUMovimiento(movimientoDto);
                _response.Result = model;
                return CreatedAtAction("GetMovimiento", new { id = model.MovimientoId }, _response);
            }
            catch (Exception ex)
            {

                _response.IsSuccess = false;
                _response.DisplayMessage = "Error al Grabar el Registro";
                _response.ErrorMessages = new List<string> { ex.ToString() };
                return BadRequest(_response);
            }

        }

        // DELETE: api/Movimiento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovimiento(int id)
        {
            try
            {
                bool estaEliminado = await _movimientoRepositorio.DeleteMovimiento(id);
                if (estaEliminado)
                {
                    _response.Result = estaEliminado;
                    _response.DisplayMessage = "Movimiento Eliminado con Exito";
                    return Ok(_response);
                }
                else
                {
                    _response.IsSuccess = false;
                    _response.DisplayMessage = "Error al Eliminar Movimiento";
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
