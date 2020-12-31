using MvcInstitute.Repository;
using System.Web.Mvc;

namespace MvcInstitute.Controllers
{
    [Route("Subject")]
    public class SubjectController : Controller
    {
        private Student_Repository _studentRepo = new Student_Repository();
        private Subject_Repository _subject_Repo = new Subject_Repository();
                
        public ActionResult Index()
        {
            return View();
        }

        [Route("Subject/Subject_Record")]
        public ActionResult Subject_Record()
        {
            var vacant_Subject = _subject_Repo.Vacant_Subjects();
            return View(vacant_Subject);
        }
    }
}