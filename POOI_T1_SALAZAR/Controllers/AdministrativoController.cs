using System.Web.Mvc;
using POOI_T1_SALAZAR.Models;

namespace POOI_T1_SALAZAR.Controllers
{
    public class AdministrativoController : Controller
    {
        //Registra al Administrativo
        [HttpGet]
        public ActionResult RegistrarAdministrativo()
        {
            return View(new Administrativo());
        }

        //Registra al Administrativo y calcula resultados
        [HttpPost]
        public ActionResult RegistrarAdministrativo(Administrativo obj)
        {
            return View(obj);
        }
    }
}