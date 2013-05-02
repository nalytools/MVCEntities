using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Ejemplo.Models;

namespace MVC_Ejemplo.Controllers
{
    public class EquipoLaboratorioController : Controller
    {
        EquipoLaboratorioDataContext equipo = new EquipoLaboratorioDataContext();
        //
        // GET: /EquipoLaboratorio/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EquipoLaboratorio()
        {
            ViewBag.Message = "Material de Laboratorio";

            var equipoResultados = from Equipo in equipo.Equipos
                                   select Equipo;

            return View(equipoResultados);
        }

    }
}
