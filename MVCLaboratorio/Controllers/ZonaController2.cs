using BussinesLogic.Controller;
using CommonSolution.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLaboratorio.Controllers
{
    public class ZonaController2
    {
        public ActionResult Listar()
        {
            ZonaController lc = new ZonaController();
            List<dtoZona> col = lc.ListarZona();

            return View(col);
        }
    }
}