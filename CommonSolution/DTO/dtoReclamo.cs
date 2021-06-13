using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoReclamo
    {
        //public string observaciones;
        public float ubicacionLatitud;
        public float ubicacionLongitud;
        public int nroReclamo;
        public DateTime fechaHora;
        public int nroZona;
        public int nroCuadrilla;
        public string observacionCuadrilla;
        public string estadoReclamo;
        public string nombreUsuario;
        public dtoTipo_Reclamo TipoReclamo;

        public List<dtoHistorial> colHistorial;
    }
}
