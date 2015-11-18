using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Students_Management
{
   public class Grade
    {
       private decimal gradeValue;
       public decimal GradeValue { get { return gradeValue; } }

       public Grade(decimal _gradeValue)
        {
            Contract.Requires<ArgumentException>(_gradeValue > 0);
            Contract.Requires<ArgumentException>(_gradeValue <= 10);

            gradeValue = _gradeValue;
         }
   }
}
