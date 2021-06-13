using CommonSolution.DTO;
using DataAccess.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Controller
{
    public class CuadrillaController
    {
        private Repository _repository;

        public void AltaCuadrilla(dtoCuadrilla dto)
        {
            if (!this._repository.getCuadrillaRepository().ExisteCuadrilla(dto.numero))
            {
                this._repository.getCuadrillaRepository().AltaCuadrilla(dto);
            }
        }
        public void BajaCuadrilla(dtoCuadrilla dto)
        {
            if (this._repository.getCuadrillaRepository().ExisteCuadrilla(dto.numero))
            {
                this._repository.getCuadrillaRepository().BajaCuadrilla(dto);
            }
        }
        public dtoCuadrilla getCuadrilla(dtoCuadrilla dto)
        {
            dtoCuadrilla cargar = new dtoCuadrilla();
            if (this._repository.getCuadrillaRepository().ExisteCuadrilla(dto.numero))
            {
                cargar = this._repository.getCuadrillaRepository().getCuadrilla(dto.numero);
            }
            return cargar;
        }

    }
}
