using MvcInstitute.Models;
using MvcInstitute.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace MvcInstitute.Repository
{
    public class Student_Repository
    {       
        public Student_Repository()
        {

        }        

        public object Registered_Student_Check(ViewModel_Login loginStudent)
        {
            Student oStudent = new Student();            
            using (InstituteDb _context = new InstituteDb())
            {
                oStudent = (from d in _context.Student
                            where d.Dni == loginStudent.Dni && d.Docket == loginStudent.Docket
                            select d).First();                                    
            }
            return oStudent;
        }

        public object Registered_Admin_Check(ViewModel_Login loginAdmin)
        {            
            Admin oAdmin_Result = new Admin();            
            using (InstituteDb _context = new InstituteDb())
            {
                oAdmin_Result = (from d in _context.Admin
                                where d.Dni == loginAdmin.Dni && d.Docket == loginAdmin.Docket
                                select d).First();
            }
            return oAdmin_Result;
        }

        public object Model_Login(string user, ViewModel_Login _login)
        {
            object oUser;
            switch (user)
            {
                case "stud":
                     oUser = Registered_Student_Check(_login);
                    return oUser;                    
                case "admi":
                     oUser = Registered_Admin_Check(_login);
                    return oUser;
                default:
                    return null;
            }            
        }

        public List<string> action_Result(string value)
        {
            if (value == "stud") return new List<string>() { "Subject_Record", "Subject" };
            else return new List<string>() { "Admin_Pag", "Admin" };

        }
    }    
}