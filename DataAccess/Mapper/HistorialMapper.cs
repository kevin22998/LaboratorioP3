using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class HistorialMapper
    {
        public dtoHistorial MaptoDto(Historial entity)
        {
            dtoHistorial cargar = new dtoHistorial();

            cargar.fechaHora = entity.fechayhora.ToString();
            cargar.comentario = entity.comentario;
            cargar.estado = entity.estado;
            cargar.id = entity.id;
            cargar.nroReclamo = entity.nroReclamo;

            return cargar;
        }
        public Historial MaptoEntity(dtoHistorial dto)
        {
            Historial cargar = new Historial();

            cargar.fechayhora = DateTime.Parse(dto.fechaHora);
            cargar.comentario = dto.comentario;
            cargar.estado = dto.estado;
            cargar.id = dto.id;
            cargar.nroReclamo = dto.nroReclamo;

            return cargar;
        }
        public List<Historial> MaptoEntity(List<dtoHistorial> dto)
        {
            List<Historial> cargar = new List<Historial>();

            foreach (dtoHistorial item in dto)
            {
                cargar.Add(MaptoEntity(item));
            }

            return cargar;
        }
        public List<dtoHistorial> MaptoDto(List<Historial> entity)
        {
            List<dtoHistorial> cargar = new List<dtoHistorial>();

            foreach (Historial item in entity)
            {
                cargar.Add(MaptoDto(item));
            }

            return cargar;
        }
    }
}
