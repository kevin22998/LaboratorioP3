using CommonSolution.DTO;
using DataAccess.Mapper;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ZonaRepository
    {
        private ZonaMapper _ZonaMapper;
        private GPSMapper _GPSMapper;
        public void AltaZona(dtoZona dto)
        {
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Zona cargar = this._ZonaMapper.MaptoEntity(dto);

                        context.Zona.Add(cargar);
                        context.SaveChanges();
                        trann.Commit();
                    }
                    catch (Exception ex)
                    {
                        trann.Rollback();
                    }
                }
            }
        }
        public bool ExisteZona(int id)
        {
            bool resultado = false;
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                resultado = context.Zona.Any(a => a.numero == id);
            }
            return resultado;
        }
        public void AgregarGPSZona(dtoGPS dto, dtoZona zona)
        {
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Zona entity = context.Zona.AsNoTracking().FirstOrDefault(a => a.numero == zona.numero);
                        entity.Gps.Add(this._GPSMapper.MaptoEntity(dto));

                        context.SaveChanges();
                        trann.Commit();
                    }
                    catch (Exception ex)
                    {

                        trann.Rollback();
                    }
                    
                }
            }
        }
        public void EliminarZona(int nro)
        {
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Zona cargar = context.Zona.AsNoTracking().FirstOrDefault(a => a.numero == nro);

                        context.Zona.Remove(cargar);  //Funca?
                        context.SaveChanges();
                        trann.Commit();
                    }
                    catch (Exception ex)
                    {
                        trann.Rollback();
                    }
                }
            }
        }
        public List<dtoZona> getListarZonas()
        {
            List<dtoZona> cargar = new List<dtoZona>();

            using (LaboratorioEntities context=new LaboratorioEntities())
            {
                List <Zona> colZona = context.Zona.AsNoTracking().Select(s => s).ToList();
                cargar = this._ZonaMapper.MaptoDto(colZona);
            }

            return cargar;
        }
    }
}
