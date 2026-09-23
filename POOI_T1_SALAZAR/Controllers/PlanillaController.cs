using System.Collections.Generic;
using System.Web.Mvc;
using POOI_T1_SALAZAR.Models;

namespace POOI_T1_SALAZAR.Controllers
{
    public class PlanillaController : Controller
    {
        // GET: Listar Planilla
        public ActionResult ListarPlanilla()
        {
            // Definimos la lista llamada Planilla con 4 objetos Empleado
            List<Empleado> Planilla = new List<Empleado>
            {
                new Empleado { idEmpleado = "E001", nomapeEmpleado = "Carlos Pérez", categoriaEmpleado = "A", nHijos = 2 },
                new Empleado { idEmpleado = "E002", nomapeEmpleado = "María Gómez", categoriaEmpleado = "B", nHijos = 1 },
                new Empleado { idEmpleado = "E003", nomapeEmpleado = "Juan Quispe", categoriaEmpleado = "C", nHijos = 3 },
                new Empleado { idEmpleado = "E004", nomapeEmpleado = "Ana Torres", categoriaEmpleado = "A", nHijos = 0 }
            };
            // Enviamos la lista a la vista
            return View(Planilla);
        }
    }
}