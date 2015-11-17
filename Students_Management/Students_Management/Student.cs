using System;
using System.Collections.Generic;
using System.Collections;

namespace Students_Management
{
    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string CNP { get; set; }
        public int RegNo { get; set; }
        public int PhoneNo { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public Array[] Grades { get; set; }

        public void displayCourseOffers()
        { }

        private void registerforCourse()
        { }

        private void saveSchedule()
        { }
       
    }

    public interface IRepository
    {
        ArrayList List { get; }
        void AddStudent(object entity);
        void UpdateStudentInfo(object entity);
        void addGrades(object entity);
    }   

}
