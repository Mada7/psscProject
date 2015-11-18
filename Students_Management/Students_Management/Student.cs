using System;
using System.Collections.Generic;
using System.Collections;

namespace Students_Management
{
    public class Student : AddForm
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string CNP { get; set; }
        public int RegNo { get; set; }
        public int PhoneNo { get; set; }
        public string Email { get; set; }
        public string Sex { get; set; }
        public Grade examGrade { get; set; }
        public Grades activityGrades { get; set; }
        public Grade finalGrade { get; set; }

       public void addStudent ()
        {
            Name = name_textBox.ToString();
            Age = Convert.ToInt16( age_textBox);
            Address = address_textBox.ToString();
            CNP = cnp_textBox.ToString();
            RegNo = Convert.ToInt16(regNo_textBox);
            PhoneNo = Convert.ToInt16(phone_textBox);
            Email = email_textBox.ToString();
            Sex = gender_comboBox.ToString();
           activityGrades = new Grades();
       }

        internal void calculateFinalGrade(Coeficient coeficient)
        {
            var valCoeficient = coeficient.Fractie;
            finalGrade = new Grade(Math.Round(valCoeficient * examGrade.GradeValue + (1 - valCoeficient) * activityGrades.calculateAverage.GradeValue));
        }
       
    }

}
