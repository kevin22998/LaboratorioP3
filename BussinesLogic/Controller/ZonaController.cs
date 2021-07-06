﻿using CommonSolution.DTO;
using DataAccess.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Controller
{
    public class ZonaController
    {
        private Repository _repository;
        public ZonaController()
        {
            this._repository = new Repository();
        }
        public void AltaZona(dtoZona dto)  //Ingresar zona
        {
            if (!this._repository.getZonaRepository().ExisteZona(dto.numero))
            {
                this._repository.getZonaRepository().AltaZona(dto);
            }
        }
        public void AgregarPuntosGPS(List<dtoGPS> dto, dtoZona zona)
        {
            if (this._repository.getZonaRepository().ExisteZona(zona.numero))
            {
                foreach (dtoGPS gps in dto)
                {
                    this._repository.getZonaRepository().AgregarGPSZona(gps, zona);
                }
            }
        }
        public void BajaZona(int nro)  //Borrar zona
        {
            if (!this._repository.getZonaRepository().ExisteZona(nro))
            {
                this._repository.getZonaRepository().EliminarZona(nro);
            }
        }
        public List<dtoZona> ListarZona()
        {
            List<dtoZona> cargar = new List<dtoZona>();

            cargar = this._repository.getZonaRepository().getListarZonas();

            return cargar;
        }
    }
}
