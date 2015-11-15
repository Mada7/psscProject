using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Management
{
    class Secretariat : Student 
    {
        private void addStudent(Student std)
        {
            std.Name = name_textBox.ToString();
            std.Age = Convert.ToInt16(age_textBox);
            std.Address = address_textBox.ToString();
            std.CNP = cnp_textBox.ToString();
            std.RegNo =Convert.ToInt16(regNo_textBox);
            std.PhoneNo = Convert.ToInt32(phone_textBox);
            std.Email = email_textBox.ToString();
            std.Sex = gender_comboBox.ToString();       
        }
        
          private void addProfInfo(Professor prof)
        {
            prof.Name = " ";
            prof.Course = " ";
        }

     }
}
