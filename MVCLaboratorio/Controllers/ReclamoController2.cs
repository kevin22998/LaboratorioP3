using BussinesLogic.Controller;
using CommonSolution.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLaboratorio.Controllers
{
    public class ReclamoController2
    {
        public ActionResult Listar()
        {
            ReclamoController lc = new ReclamoController();
            List<dtoReclamo> col = lc.getcolReclamo();

            return View(col);
        }
    }
}