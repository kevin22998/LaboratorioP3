using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class GPSMapper
    {
        public dtoGPS MaptoDto(Gps entity)
        {
            dtoGPS cargar = new dtoGPS();

            cargar.latitud = entity.latitud;
            cargar.longitud = entity.longitud;
            cargar.id = entity.id;
            cargar.nroZona = entity.numeroZona;

            return cargar;
        }
        public Gps MaptoEntity(dtoGPS dto)
        {
            Gps cargar = new Gps();

            cargar.id = dto.id;
            cargar.numeroZona = dto.nroZona;
            cargar.latitud = dto.latitud;
            cargar.longitud = dto.longitud;

            return cargar;
        }
        public List<Gps> MaptoEntity(List<dtoGPS> dto)
        {
            List<Gps> cargar = new List<Gps>();

            foreach (dtoGPS item in dto)
            {
                cargar.Add(MaptoEntity(item));
            }

            return cargar;
        }
        public List<dtoGPS> MaptoDto(List<Gps> entity)
        {
            List<dtoGPS> cargar = new List<dtoGPS>();

            foreach (Gps item in entity)
            {
                cargar.Add(MaptoDto(item));
            }

            return cargar;
        }
    }
}
