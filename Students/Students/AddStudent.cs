using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class AddStudent : Form
    {
        System.Data.SqlClient.SqlConnection con;

        public AddStudent()
        {
            InitializeComponent();
         
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            address_textBox.Clear();
            name_textBox.Clear();
            phoneNo_textBox.Clear();
            email_textBox.Clear();
            cnp_textBox.Clear();
            regNo_textBox.Clear();
            gender_comboBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            checkData();
            var db = new SMSDataContext();
            Student newStudent = new Student();
            newStudent.Full_Name = name_textBox.Text;
            newStudent.Adress = address_textBox.Text;
            newStudent.Registration_Number = regNo_textBox.Text;
            newStudent.Phone_Number = phoneNo_textBox.Text;
            newStudent.Email = email_textBox.Text;
            newStudent.Gender = gender_comboBox.Text;
            newStudent.CNP = cnp_textBox.Text;
            db.Students.InsertOnSubmit(newStudent);
            MessageBox.Show("Student Succesfully added !", " ", MessageBoxButtons.OK,MessageBoxIcon.Information);
            clearButton_Click(sender,e);
        }
        private void checkData()
        {
            if (name_textBox.Text == "" || address_textBox.Text == "" || phoneNo_textBox.Text == "" || email_textBox.Text ==
                "" || cnp_textBox.Text == "" || regNo_textBox.Text == "" || gender_comboBox.Text == "")
                MessageBox.Show("Invalid data insert. Check again!"," ",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;
                          AttachDbFilename=E:\POLI\git\Students\Students\Database1.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;
                          User Instance=True";
            con.Open();
        }

        
    }
}
