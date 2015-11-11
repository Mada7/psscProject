using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Management
{
    public class Student
    {
        private int _id;
        private int _age;
        private string _name;
        private string _address;
        private string _cnp;
        private int _regNo;
        private int _phoneNo;
        private string _email;
        private string _sex;


        public Student(int age, string name, string address, string cnp, int regNo, int phoneNo, string email, string sex)
        {
            _age = age;
            _name = name;
            _address = address;
            _cnp = cnp;
            _regNo = regNo;
            _phoneNo = phoneNo;
            _email = email;
            _sex = sex;
        }

        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
        public string Address { get { return _address; } }
        public string CNP { get { return _cnp; } }
        public int RegNo { get { return _regNo; } }
        public int PhoneNo { get { return _phoneNo; } }
        public string Email { get { return _email; } }
        public string Sex { get { return _sex; } }
    }
}
