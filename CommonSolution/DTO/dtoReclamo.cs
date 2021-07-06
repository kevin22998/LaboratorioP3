using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoReclamo
    {
        [DisplayName("Observaciones:")]
        [StringLength(25, ErrorMessage = "100 caracteres maximo")]
        [Required(ErrorMessage = "Observaciones es requerido")]
        public string observaciones{ get; set; }

        [DisplayName("Latitud:")]
        [StringLength(25, ErrorMessage = "25 caracteres maximo")]
        [Required(ErrorMessage = "Latitud es requerido")]
        public string ubicacionLatitud { get; set; }

        [DisplayName("Longitud:")]
        [StringLength(25, ErrorMessage = "25 caracteres maximo")]
        [Required(ErrorMessage = "Longitud es requerido")]
        public string ubicacionLongitud { get; set; }

        [DisplayName("Numero Reclamo:")]
        public int nroReclamo { get; set; }

        [DisplayName("Fecha y Hora:")]
        public DateTime fechaHora { get; set; }

        [DisplayName("Numero Zona:")]
        public int nroZona { get; set; }

        [DisplayName("Numero Cuadrilla:")]
        public int nroCuadrilla { get; set; }

        [DisplayName("Observacion Cuadrilla:")]
        public string observacionCuadrilla { get; set; }

        [DisplayName("Estado:")]
        public string estadoReclamo { get; set; }

        [DisplayName("Nombre Usuario:")]
        public string nombreUsuario { get; set; }

        [DisplayName("Tipo Reclamo:")]
        public dtoTipo_Reclamo TipoReclamo { get; set; }

        [DisplayName("Historial:")]
        public List<dtoHistorial> colHistorial { get; set; }
    }
}
