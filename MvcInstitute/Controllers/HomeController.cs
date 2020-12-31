using MvcInstitute.Repository;
using MvcInstitute.ViewModels;
using System;
using System.Web.Mvc;

namespace MvcInstitute.Controllers
{
    public class HomeController : Controller
    {
        private Student_Repository _repo = new Student_Repository();
        private Admin_Repository Admin_Repository = new Admin_Repository();

        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult Login(string message="")
        {
            ViewBag.Message = message;
            return View();
        }

        [HttpPost]
        public ActionResult Login(ViewModel_Login model)
        {
            try
            {
                var url_action = _repo.action_Result(Request.Form["user"].ToString());
                var oUser = _repo.Model_Login(Request.Form["user"].ToString(), model);
                if (oUser == null)
                {
                    return RedirectToAction("Login", new { message = "Select user type and fill in the requested data." });
                }
                Session["User"] = oUser;
                return RedirectToAction(url_action[0], url_action[1]);                                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }

        


        /* Ver  tema login: filtro para que no entre en donde no deba siendo un usuario no permitido.
              tema materias: al elegir en la lista de materias vacantes que muestre la info elegida.
              tema estudiantes: alta/baja de materias.
        */


        
    }
}