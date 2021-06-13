using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class ZonaMapper
    {
        public dtoZona MaptoDto(Zona entity)
        {
            dtoZona cargar = new dtoZona();

            cargar.nombre = entity.nombre;
            cargar.numero = entity.numero;
            cargar.color = entity.color;

            return cargar;
        }
        public Zona MaptoEntity(dtoZona dto)
        {
            Zona cargar = new Zona();

            cargar.nombre = dto.nombre;
            cargar.numero = dto.numero;
            cargar.color = dto.color;

            return cargar;
        }
        public List<dtoZona> MaptoDto(List<Zona> entity)
        {
            List<dtoZona> cargar = new List<dtoZona>();

            foreach (Zona item in entity)
            {
                cargar.Add(MaptoDto(item));
            }

            return cargar;
        }
        public List<Zona> MaptoEntity(List<dtoZona> dto)
        {
            List<Zona> cargar = new List<Zona>();

            foreach (dtoZona item in dto)
            {
                cargar.Add(MaptoEntity(item));
            }

            return cargar;
        }
    }
}
