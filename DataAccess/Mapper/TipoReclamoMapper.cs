using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class TipoReclamoMapper
    {
        public dtoTipo_Reclamo MaptoDto(TipoReclamo reclamo)
        {
            dtoTipo_Reclamo cargar = new dtoTipo_Reclamo();

            cargar.nombre = reclamo.nombre;
            cargar.numero = reclamo.numero;
            cargar.descripcion = reclamo.descripcion;
            cargar.nroReclamo = reclamo.reclamoNumero;

            return cargar;
        }
        public TipoReclamo MaptoEntity(dtoTipo_Reclamo dto)
        {
            TipoReclamo cargar = new TipoReclamo();

            cargar.nombre = dto.nombre;
            cargar.numero = dto.numero;
            cargar.descripcion = dto.descripcion;
            cargar.reclamoNumero = dto.nroReclamo;

            return cargar;
        }
    }
}
