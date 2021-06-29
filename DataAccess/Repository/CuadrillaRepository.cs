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
    public class CuadrillaRepository
    {
        private CuadrillaMapper _CuadrillaMapper;
        public CuadrillaRepository()
        {
            this._CuadrillaMapper = new CuadrillaMapper();
        }
        public void AltaCuadrilla(dtoCuadrilla dto)
        {
            using (LaboratorioEntities context=new LaboratorioEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Cuadrilla cargar = this._CuadrillaMapper.MaptoEntity(dto);

                        context.Cuadrilla.Add(cargar);
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
        public bool ExisteCuadrilla(int nro)
        {
            bool x = false;
            using (LaboratorioEntities context=new LaboratorioEntities())
            {
                x = context.Cuadrilla.Any(a => a.numero == nro);
            }
            return x;
        }
        public void BajaCuadrilla(dtoCuadrilla dto)
        {
            using (LaboratorioEntities context=new LaboratorioEntities())
            {
                using (DbContextTransaction trann= context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Cuadrilla cargar = this._CuadrillaMapper.MaptoEntity(dto);
                        
                        context.Cuadrilla.Remove(cargar);
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
        public dtoCuadrilla getCuadrilla(int nro)
        {
            dtoCuadrilla cargar;
            using (LaboratorioEntities context=new LaboratorioEntities())
            {
                cargar = this._CuadrillaMapper.MaptoDto(context.Cuadrilla.FirstOrDefault(a => a.numero == nro));
            }

            return cargar;
        }
    }
}
