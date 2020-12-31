using MvcInstitute.Models;
using System.Collections.Generic;

namespace MvcInstitute.ViewModels
{
    public class ViewModel_Data_Manager
    {
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}