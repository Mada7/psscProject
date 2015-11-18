using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace Students_Management
{
    public class Course
    {
        public string Name { get; internal set; }

        internal Course(string name)
        {
            Contract.Requires(name != null);
            Name = name;
        }

    }

    public class Courses
    {
        private List<Course> _courses;
        public ReadOnlyCollection<Course> Valori { get { return _courses.AsReadOnly(); } }

        internal Courses()
        {
            _courses = new List<Course>();
        }

        internal Courses(List<Course> courses)
        {
            Contract.Requires(courses != null);
            _courses = courses;
        }

        internal void addCourse(Course course)
        {
            Contract.Requires(course != null);
            _courses.Add(course);
        }
    }

}



       

 

