using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoHistorial
    {
        //public enum ESTADOS :{ PENDIENTE, ASIGNADO, EN_PROCESO, RESUELTO, DESESTIMADO };

        public string estado { get; set; }
        public string fechaHora { get; set; }
        public string comentario { get; set; }
        public int id { get; set; }
        public int nroReclamo { get; set; }
    }
}
