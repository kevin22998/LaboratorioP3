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
    public class ReclamoRepository
    {
        private ReclamoMapper _reclamoMapper;
        private HistorialMapper _historialMapper;

        public void AltaReclamo(dtoReclamo dto)
        {
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Reclamo cargar = this._reclamoMapper.MaptoEntity(dto);

                        context.Reclamo.Add(cargar);
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

        public bool ExiteReclamo(int id)
        {
            bool resultado = true;
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                resultado = context.Reclamo.Any(a => a.numero == id);
            }
            return resultado;
        }
        /*
        public List<dtoReclamo> getListaReclamoCiudadano(long id)
        {
            List<dtoReclamo> cargar = new List<dtoReclamo>();
            
            using (LaboratorioEntities context=new LaboratorioEntities())
            {
                Ciudadano ElCiudadano = context.Ciudadano.AsNoTracking().FistOrDefault(a => a.idCiudadano == id);

                cargar = this._reclamoMapper.MaptoDto(ElCiudadano.colReclamo);
            }

            return cargar;
        }
        */
        public void AgregarHistorial(dtoHistorial dtoH, dtoReclamo dtoR)
        {
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Reclamo entity = context.Reclamo.AsNoTracking().FirstOrDefault(a => a.numero == dtoR.nroReclamo);
                        entity.Historial.Add(this._historialMapper.MaptoEntity(dtoH));
                        
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
        public List<dtoHistorial> getHistorialReclamo(int nro)
        {
            List<dtoHistorial> cargar = new List<dtoHistorial>();

            using (LaboratorioEntities context=new LaboratorioEntities())
            {
                cargar = this._historialMapper.MaptoDto(context.Historial.AsNoTracking().Where(a => a.nroReclamo == nro).ToList());
            }

            return cargar;
        }
        public List<dtoReclamo> getListarReclamo()
        {
            List<dtoReclamo> cargar = new List<dtoReclamo>();

            using (LaboratorioEntities context=new LaboratorioEntities())
            {
                List<Reclamo> entity = context.Reclamo.AsNoTracking().Select(a => a).ToList();
                cargar = this._reclamoMapper.MaptoDto(entity);
            }

            return cargar;
        }
    }
}
