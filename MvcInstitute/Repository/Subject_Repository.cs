using MvcInstitute.Models;
using MvcInstitute.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcInstitute.Repository
{
    public class Subject_Repository
    {
        public Subject_Repository()
        {

        }

        public List<ViewModel_Subject> Vacant_Subjects()
        {
            try
            {
                List<ViewModel_Subject> Vacant_Subjects = new List<ViewModel_Subject>();
                using (InstituteDb _context = new InstituteDb())
                {
                    var List_Of_Subjects = (from d in _context.Subject
                                            select d).ToList();

                    foreach (var elem in List_Of_Subjects)
                    {
                        if (elem.Enrolled < elem.Quota)
                        {
                            ViewModel_Subject subject = new ViewModel_Subject();
                            subject.Name = elem.Name;
                            subject.Teacher = elem.Teacher;
                            subject.Schedule = elem.Schedule;
                            subject.Information = elem.Information;
                            subject.Vacant = elem.Enrolled + "/" + elem.Quota;
                            Vacant_Subjects.Add(subject);
                        }
                    }
                    return Vacant_Subjects;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}