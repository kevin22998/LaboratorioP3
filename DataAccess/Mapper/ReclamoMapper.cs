using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class ReclamoMapper
    {
        public dtoReclamo MaptoDto(Reclamo entity)
        {
            dtoReclamo cargar = new dtoReclamo();

            cargar.nombreUsuario = entity.usuarioNombre;
            cargar.ubicacionLatitud = entity.latitud;
            cargar.ubicacionLongitud = entity.longitud;
            cargar.nroReclamo = entity.numero;
            cargar.nroZona = entity.nroZona;
            cargar.nroCuadrilla = entity.nroCuadrilla;
            cargar.fechaHora = entity.fechayhora;
            cargar.estadoReclamo = entity.estado;
            cargar.observacionCuadrilla = entity.observacionCuadrilla;

            return cargar;
        }
        public Reclamo MaptoEntity(dtoReclamo dto)
        {
            Reclamo cargar = new Reclamo();

            cargar.usuarioNombre = dto.nombreUsuario;
            cargar.latitud = dto.ubicacionLatitud;
            cargar.longitud = dto.ubicacionLongitud;
            cargar.numero = dto.nroReclamo;
            cargar.nroZona = dto.nroZona;
            cargar.nroCuadrilla = dto.nroCuadrilla;
            cargar.fechayhora = dto.fechaHora;
            cargar.estado = dto.estadoReclamo;
            cargar.observacionCuadrilla = dto.observacionCuadrilla;

            return cargar;
        }
        public List<Reclamo> MaptoEntity(List<dtoReclamo> colDto)
        {
            List<Reclamo> cargar = new List<Reclamo>();

            foreach (dtoReclamo item in colDto)
            {
                cargar.Add(MaptoEntity(item));
            }

            return cargar;
        }
        public List<dtoReclamo> MaptoDto(List<Reclamo> colEntity)
        {
            List<dtoReclamo> cargar = new List<dtoReclamo>();

            foreach (Reclamo item in colEntity)
            {
                cargar.Add(MaptoDto(item));
            }

            return cargar;
        }
    }
}
