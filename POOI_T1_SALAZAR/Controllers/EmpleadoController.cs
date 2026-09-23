using System.Collections.Generic;
using System.Web.Mvc;
using POOI_T1_SALAZAR.Models;

namespace POOI_T1_SALAZAR.Controllers
{
    public class EmpleadoController : Controller
    {
        //Colección en memoria para guardar
        private static List<Empleado> listaEmpleados = new List<Empleado>();

        //GET: Muestra la lista de todos los empleados registrados
        public ActionResult Index(){
            return View(listaEmpleados);
        }

        //GET
        [HttpGet]
        public ActionResult RegistrarEmpleado(){
            return View(new Empleado());
        }

        //POST
        [HttpPost]
        public ActionResult RegistrarEmpleado(Empleado obj){
            //Agregamos el objeto a nuestra lista en memoria
            listaEmpleados.Add(obj);

            //Redirigimos para vre la tabla con todos los registros
            return RedirectToAction("Index");
        }
    }
}