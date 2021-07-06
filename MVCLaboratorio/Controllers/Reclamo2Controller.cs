using BussinesLogic.Controller;
using CommonSolution.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLaboratorio.Controllers
{
    public class Reclamo2Controller : Controller
    {
        // GET: Reclamo2
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Listar()
        {
            ReclamoController lc = new ReclamoController();
            List<dtoReclamo> col = lc.getcolReclamo();

            return View(col);
        }
        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AgregarReclamo(dtoReclamo dto)
        {
            ReclamoController cargar = new ReclamoController();
            dtoGPS ubicacion = new dtoGPS();
            ubicacion.latitud = dto.ubicacionLatitud;
            ubicacion.longitud = dto.ubicacionLongitud;
            dtoUsuario usuario = new dtoUsuario();
            usuario.nombreUsuario = dto.nombreUsuario;

            cargar.IngresoReclamo(dto.TipoReclamo, dto.observaciones, ubicacion, usuario);

            return View("Agregar");
        }
    }
}