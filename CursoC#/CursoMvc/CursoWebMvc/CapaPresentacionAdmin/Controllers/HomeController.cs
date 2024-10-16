using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacionAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Usuarios()

        {

            List<Usuario> oLista = new List<Usuario>();

            oLista = new CnUsuarios().ListaUSuarios();

           

            return View(oLista);
        }

        public ActionResult EditUsuario(int id)

        {

            CnUsuarios cnUsuarios = new CnUsuarios();

            Usuario usario = new Usuario();
            usario= cnUsuarios.editUser(id);

            return View(usario);
        }
        
        [HttpPost]
        public ActionResult EditUsuario(Usuario usuario,int id)

        {

            CnUsuarios cnUsuarios = new CnUsuarios();

            cnUsuarios.editUsuario(usuario, id);

           return RedirectToAction("Index");
        }



        public ActionResult CrearUsuario()
        {
            Usuario usuario = new Usuario();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult CrearUsuario(Usuario usuario)
        {
            CnUsuarios cnUsuarios = new CnUsuarios();

            cnUsuarios.saveUser(usuario);

            return View();

        }

        [HttpPost]
        public JsonResult EliminarUsuario(int id)
        {
            CnUsuarios cnUsuarios = new CnUsuarios();

            cnUsuarios.deleteUser(id);

            return Json(new { success = true, message = "Usuario eliminado con éxito." });
        }



    }

}