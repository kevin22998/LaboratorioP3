using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class UsuarioMapper
    {
        public dtoUsuario MaptoDto(Usuario persona)
        {
            dtoUsuario cargar = new dtoUsuario();

            cargar.nombreUsuario = persona.nombreUsusario;
            cargar.contraseña = persona.contraseña;
            cargar.nombre = persona.nombre;
            cargar.apellido = persona.apellido;
            cargar.telefono = persona.telefono;
            cargar.correo = persona.correo;
            cargar.tipo = persona.tipo;

            return cargar;
        }
        public Usuario MaptoEntity(dtoUsuario dto)
        {
            Usuario cargar = new Usuario();

            cargar.nombreUsusario = dto.nombreUsuario;
            cargar.contraseña = dto.contraseña;
            cargar.nombre = dto.nombre;
            cargar.apellido = dto.apellido;
            cargar.telefono = dto.telefono;
            cargar.correo = dto.correo;
            cargar.tipo = dto.tipo;

            return cargar;
        }
    }
}
