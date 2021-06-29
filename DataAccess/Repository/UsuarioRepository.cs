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
    public class UsuarioRepository
    {
        private UsuarioMapper _usuarioMapper;
        private ReclamoMapper _reclamoMapper;
        public UsuarioRepository()
        {
            this._usuarioMapper = new UsuarioMapper();
            this._reclamoMapper = new ReclamoMapper();
        }
        public void AltaCiudadano(dtoUsuario dto)
        {
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Usuario cargar = this._usuarioMapper.MaptoEntity(dto);
                        //cargar.Reclamo=null       Lista de reclamos nulas

                        context.Usuario.Add(cargar);
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
        public void AltaFuncionario(dtoUsuario dto)
        {
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Usuario cargar = this._usuarioMapper.MaptoEntity(dto);
                        

                        context.Usuario.Add(cargar);
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
        public bool ExisteUsuario(string nombreUsuario)
        {
            bool resultado = false;
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                resultado = context.Usuario.Any(a => a.nombreUsusario == nombreUsuario);
            }
            return resultado;
        }
        public bool getUsuarioControlAcceso(string nombreUsuario, string contraseña)
        {
            bool x = false;
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                Usuario entity = context.Usuario.FirstOrDefault(a => a.nombreUsusario == nombreUsuario);
                if (entity.contraseña==contraseña)
                {
                    x = true;
                }
            }
            return x;
        }

        public void AgregarReclamoLista(dtoReclamo dto, string idUsuario)
        {
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                using (DbContextTransaction trann = context.Database.BeginTransaction(IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        Usuario entity = context.Usuario.AsNoTracking().FirstOrDefault(a => a.nombreUsusario == idUsuario);
                        entity.Reclamo.Add(this._reclamoMapper.MaptoEntity(dto));

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
        public List<dtoReclamo> getColReclamoCiudadano(string usuario)
        {
            List<dtoReclamo> cargar=new List<dtoReclamo>();
            using (LaboratorioEntities context = new LaboratorioEntities())
            {
                Usuario entity = context.Usuario.AsNoTracking().Include("Reclamo").FirstOrDefault(a => a.nombreUsusario == usuario);
                cargar = this._reclamoMapper.MaptoDto(entity.Reclamo.ToList());

                
            }
            return cargar;
        }
    }   
}
