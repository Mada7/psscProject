using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.Contracts;

namespace Students_Management
{
    public enum CourseStatus
    {
        Starting,
        OnGoing,
        Done
    }

    public class Coeficient
    {
        private int _numarator;
        private int _numitor;

        public decimal Fractie { get { return (decimal)_numarator / (decimal)_numitor; } }

        internal Coeficient(int numarator, int numitor)
        {
            Contract.Requires<ArgumentException>(numarator > 0);
            Contract.Requires<ArgumentException>(numitor > 0);
            Contract.Requires<ArgumentException>(numitor > numarator);

            _numitor = numitor;
            _numarator = numarator;
        }
    }

    public class handleCourse
    {
        public string CourseName { get; set; }
        public Coeficient ExamBalance { get; set; }
        public CourseStatus Status { get; set; }
        public Courses Courses { get; set; }

        private List<Student> _submittedStudents;
        public IReadOnlyCollection<Student> SubmittedStudents { get { return _submittedStudents; } }

        internal handleCourse ( string name, Coeficient balance)
        {
            CourseName = name;
            ExamBalance = balance;
            _submittedStudents = new List<Student>();
            Status = CourseStatus.Starting;
            Courses = new Courses();
        }

        internal handleCourse(string name,Coeficient balance, List<Student> submittedStuds)
            :this(name,balance)
        {
            Contract.Requires(submittedStuds != null);
            _submittedStudents = submittedStuds;
        }

        public void registerStudent(Student student)
        {
            Contract.Requires(Status == CourseStatus.Starting);
            var tempRegister = _submittedStudents.FirstOrDefault(s => s.Equals(student));
            if(tempRegister == null)
            {
                _submittedStudents.Add(student);
            }
            else
            {
                throw new Exception();
            }
        }

        public void submitGrades(Student student, Coeficient balance)
        { 
            foreach (var stud in _submittedStudents)
            {
                stud.calcFinalGrade(balance);
            }
        }
                
    }
}