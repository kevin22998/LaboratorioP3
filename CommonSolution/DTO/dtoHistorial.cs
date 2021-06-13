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

        public string estado;
        public string fechaHora;
        public string comentario;
        public int id;
        public int nroReclamo;
    }
}
