using CommonSolution.DTO;
using DataAccess.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Controller
{
    public class UsuarioController
    {
        private Repository _repository;
        public UsuarioController()
        {
            this._repository = new Repository();
        }

        public void RegistroUsuarioCiudadano(dtoUsuario dto)
        {
            if (!this._repository.getUsuarioRepository().ExisteUsuario(dto.nombreUsuario))
            {
                this._repository.getUsuarioRepository().AltaCiudadano(dto);
            }
        }
        public bool ControlAcceso(dtoUsuario dto)
        {
            bool x = this._repository.getUsuarioRepository().getUsuarioControlAcceso(dto.nombreUsuario, dto.contraseña);
            
            return x;
        }
        

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                                        //Funcionario//
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public void AltaFuncionario(dtoUsuario dto)
        {
            if(!this._repository.getUsuarioRepository().ExisteUsuario(dto.nombreUsuario))
            {
                this._repository.getUsuarioRepository().AltaCiudadano(dto);
            }
        }
        
        /*
        public void ReclamosIngresadosCambioEstado()
        {
            
        }*/
    }
}
