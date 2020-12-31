using MvcInstitute.Repository;
using System.Web.Mvc;

namespace MvcInstitute.Controllers
{
    public class AdminController : Controller
    {
        private Admin_Repository Admin_Repository = new Admin_Repository();
                
        public ActionResult Index()
        {
            return View();
        }
                
        public ActionResult Admin_Pag()
        {
            var data = Admin_Repository.data_Manager();
            return View(data);            
        }
    }
}