using MvcInstitute.Models;
using MvcInstitute.ViewModels;
using System.Linq;

namespace MvcInstitute.Repository
{
    public class Admin_Repository
    {        
        public ViewModel_Data_Manager data_Manager()
        {
            ViewModel_Data_Manager data = new ViewModel_Data_Manager();
            using (InstituteDb _context = new InstituteDb())
            {
                data.Students = (from i in _context.Student
                                    select i).ToList();
                data.Subjects = (from i in _context.Subject
                                    select i).ToList();
                data.Teachers = (from i in _context.Teacher
                                    select i).ToList();                
            }
            return data;
        }
    }
}