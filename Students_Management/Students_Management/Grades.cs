using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.Contracts;

namespace Students_Management
{
    public class Grades
    {
        private List<Grade> _grades;
        public IReadOnlyCollection<Grade> Values { get { return _grades.AsReadOnly(); } }
   
        public Grades()
        {
            _grades = new List<Grade>();
        }
        internal Grades(List<Grade> grades)
        {
            Contract.Requires(grades != null);
            _grades = grades;
        }
    
    public Grade calculateAverage
        {
            get
            {
                if (_grades.Count < 2) throw new Exception();
                return new Grade(_grades.Select(n => n.GradeValue).Average());
            }
        }

        internal void addGrade(Grade grade)
        {
            Contract.Requires(grade != null);
            _grades.Add(grade);
         }

    }

}
