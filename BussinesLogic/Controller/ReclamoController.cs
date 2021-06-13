using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic.Controller
{
    public class ReclamoController
    {
        private Repository _repository;
        public void IngresoReclamo(dtoTipo_Reclamo dtoTReclamo, string observacion, dtoGPS ubicacion, dtoUsuario persona)
        {
            //Requiero operacion que lo cargue dependiendo de la ubicacion
            //cargar.observacionCuadrilla=???
            //cargar.nroZona = operacion dentro de area
            //cargar.nroCuadrilla = ???

            dtoReclamo cargar = new dtoReclamo();
            //cargar.observaciones = observacion;   //Falta añadir a la Base de datos
            cargar.TipoReclamo = dtoTReclamo;
            //cargar.nroReclamo= Operacion creciente
            cargar.fechaHora = DateTime.Now;

            cargar.ubicacionLatitud = ubicacion.latitud;
            cargar.ubicacionLongitud = ubicacion.longitud;
            cargar.estadoReclamo = "PENDIENTE";     //corregir por enum

            cargar.colHistorial = new List<dtoHistorial>();



            if (this._repository.getUsuarioRepository().ExisteUsuario(persona.nombreUsuario))
            {
                this._repository.getReclamoRepository().AltaReclamo(cargar);

                this._repository.getUsuarioRepository().AgregarReclamoLista(cargar, persona.nombreUsuario);
            }
        }
        public List<dtoReclamo> ConsultaColReclamos(string idUsuario)
        {
            List<dtoReclamo> retornar = this._repository.getUsuarioRepository().getColReclamoCiudadano(idUsuario);  //Corregir

            return retornar;
        }
        public List<dtoHistorial> ConsultaHistorialReclamo(int nro)    //Arreglar funcion
        {
            List<dtoHistorial> cargar = new List<dtoHistorial>();

            cargar = this._repository.getReclamoRepository().getHistorialReclamo(nro);

            return cargar;
        }
    }
}
