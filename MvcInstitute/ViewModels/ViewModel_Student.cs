using System.Collections.Generic;

namespace MvcInstitute.ViewModels
{
    public class ViewModel_Student
    {
        public int Docket { get; set; }
        public IEnumerable<string> Enrolled_Subject { get; set; }
    }
}