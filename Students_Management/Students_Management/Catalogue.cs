using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Students_Management
{
    class Catalogue : IRepository
    {
        private readonly ArrayList grades;
        public Catalogue()
        {
            grades = new ArrayList();
        }

        public ArrayList List
        {
            get { return grades; }
        }

        public void addGrades(Student entity)
        {
            var studIndex = grades.IndexOf(entity);
            var studToUpdate = grades[studIndex] as Student;
            if (studToUpdate != null)
            {
                var newUser = (Student)entity;
                studToUpdate.Grades = newUser.Grades;
            }
            else
            {
                throw new Exception("User not found");
            }
        }



    }
}
