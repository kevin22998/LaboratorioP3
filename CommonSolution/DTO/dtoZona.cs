using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoZona
    {
        public int numero { get; set; }
        public string nombre { get; set; }
        public string color { get; set; }

        public List<dtoGPS> colGps { get; set; }
        /* public dtoReclamo zonaReclamo;
         public List<dtoCuadrilla> colCuadrilla;*/
    }
}
