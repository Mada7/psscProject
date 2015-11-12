using System;
using System.Collections.Generic;

namespace Students_Management
{
    public class Student 
    {
  
        public string Name {  get; set; }
        public int Age {  get; set; }
        public string Address {  get; set; }
        public string CNP {  get; set; }
        public int RegNo {  get; set; }
        public int PhoneNo {  get; set; }
        public string Email {  get; set; }
        public string Sex {  get; set; }
    }

    public class manageStud : AddForm 
    {
           public void addStudent(Student std)
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

        public static void deleteStudent(Student std)
        {

        }
    }
    
}
