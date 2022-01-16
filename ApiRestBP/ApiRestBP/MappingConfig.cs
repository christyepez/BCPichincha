using ApiRestBP.Models;
using ApiRestBP.Models.Dto;
using AutoMapper;

namespace ApiRestBP
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ClienteDto, Cliente>();
                config.CreateMap<Cliente, ClienteDto>();

                config.CreateMap<CuentaDto, Cuenta>();
                config.CreateMap<Cuenta, CuentaDto>();


                config.CreateMap<MovimientoDto, Movimiento>();
                config.CreateMap<Movimiento, MovimientoDto>();


                config.CreateMap<UserDto, User>();
                config.CreateMap<User, UserDto>();

            });

            return mappingConfig;
        }
    }
}
