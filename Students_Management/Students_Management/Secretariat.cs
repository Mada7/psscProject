using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Students_Management
{
    class Secretariat : IRepository 
    {

        private readonly ArrayList _students;
        public Secretariat()
        {
            _students = new ArrayList();
        }

        public ArrayList List
        {
            get { return _students; }
        }

        public void AddStudent(Student entity)
        {
            _students.Add(entity);
        }

        public void UpdateStudentInfo(Student entity)
        {
            var studIndex = _students.IndexOf(entity);
            var studToUpdate = _students[studIndex] as Student;
            if (studToUpdate != null)
            {
                var newUser = (Student)entity;
                studToUpdate.Name = newUser.Name;
                studToUpdate.Age = newUser.Age;
                studToUpdate.Address = newUser.Address;
                studToUpdate.CNP = newUser.CNP;
                studToUpdate.RegNo = newUser.RegNo;
                studToUpdate.PhoneNo = newUser.PhoneNo;
                studToUpdate.Sex = newUser.Sex;
                studToUpdate.Grades = newUser.Grades;
            }
            else
            {
                throw new Exception("User not found");
            }
        }



          private void addProfInfo(Professor prof)
        {
            prof.Name = "";
            prof.Course = "";
        }

     }
}
