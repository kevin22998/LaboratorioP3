using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class CuadrillaMapper
    {
        public dtoCuadrilla MaptoDto(Cuadrilla entity)
        {
            dtoCuadrilla cargar = new dtoCuadrilla();

            cargar.numero = entity.numero;
            cargar.nombre = entity.nombre;
            cargar.cantPeones = entity.cantidadPeones;

            return cargar;
        }
        public Cuadrilla MaptoEntity(dtoCuadrilla dto)
        {
            Cuadrilla cargar = new Cuadrilla();

            cargar.numero = dto.numero;
            cargar.nombre = dto.nombre;
            cargar.cantidadPeones = dto.cantPeones;

            return cargar;
        }
        public List<dtoCuadrilla> MaptoDto(List<Cuadrilla> entity)
        {
            List<dtoCuadrilla> cargar = new List<dtoCuadrilla>();

            foreach (Cuadrilla item in entity)
            {
                cargar.Add(MaptoDto(item));
            }

            return cargar;
        }
        public List<Cuadrilla> MaptoEntity(List<dtoCuadrilla> dto)
        {
            List<Cuadrilla> cargar = new List<Cuadrilla>();

            foreach (dtoCuadrilla item in dto)
            {
                cargar.Add(MaptoEntity(item));
            }

            return cargar;
        }
    }
}
