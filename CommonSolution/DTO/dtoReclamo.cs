using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoReclamo
    {
        public string observaciones{ get; set; }
        public string ubicacionLatitud { get; set; }
        public string ubicacionLongitud { get; set; }
        public int nroReclamo { get; set; }
        public DateTime fechaHora { get; set; }
        public int nroZona { get; set; }
        public int nroCuadrilla { get; set; }
        public string observacionCuadrilla { get; set; }
        public string estadoReclamo { get; set; }
        public string nombreUsuario { get; set; }
        public dtoTipo_Reclamo TipoReclamo { get; set; }

        public List<dtoHistorial> colHistorial { get; set; }
    }
}
