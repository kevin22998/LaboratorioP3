using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoUsuario
    {
        [DisplayName("Nombre Usuario:")]
        [StringLength(25, ErrorMessage ="25 caracteres maximo")]
        [Required(ErrorMessage ="Nombre de usuario es requerido")]
        public string nombreUsuario { get; set; }

        [DisplayName("Contraseña:")]
        [StringLength(10, ErrorMessage ="10 caracteres maximo")]
        [Required(ErrorMessage ="Contraseña es requerida")]
        public string contraseña { get; set; }

        [DisplayName("Nombre:")]
        [StringLength(50, ErrorMessage ="50 caraacteres maximo")]
        [Required(ErrorMessage = "Nombre es requerido")]
        public string nombre { get; set; }

        [DisplayName("Apellido:")]
        [StringLength(50, ErrorMessage = "50 caraacteres maximo")]
        [Required(ErrorMessage = "Apellido es requerido")]
        public string apellido { get; set; }

        [DisplayName("Correo:")]
        [StringLength(50, ErrorMessage = "50 caraacteres maximo")]
        [Required(ErrorMessage = "Correo es requerido")]
        public string correo { get; set; }

        [DisplayName("Telefono:")]
        public string telefono { get; set; }
        public string tipo { get; set; }
    }
}
