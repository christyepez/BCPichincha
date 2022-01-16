using System;
using Xunit; 
using ApiRestBP.Controllers; 
using System.Collections.Generic;
using ApiRestBP.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace UnitTesting
{
    public class UnitTest1
    {
        private readonly IClienteRepositorio _clienteRepositorio;
      
        [Fact]
        public async void Test1()
        {
            var controller = new ClientesController(_clienteRepositorio);


            var contenido = await controller.GetCliente(7);
              

            Assert.IsType<NotFoundResult>(contenido.Result);

        }
    }
}
