using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Students_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                //This is my insert query in which i am taking input from the user through windows forms
                string Query = "INSERT INTO `pssc`.`students` ('ID' `fullName`, `regNumber`, `gender`, `address`, `phoneNumber`, `email`, `cnp`) VALUES ('" + null + "','" + this.name_textBox.Text + "','" + this.regNo_textBox.Text + "','" + this.address_textBox.Text + "','" + this.phone_textBox + "','" + this.email_textBox.Text + "','"  + this.gender_comboBox.Text + "');";
                //string Query = "INSERT INTO `pssc`.`students` (`ID`, `fullName`, `regNumber`, `gender`, `address`, `phoneNumber`, `email`, `cnp`) VALUES ('null', 'asd', 'asafsd', 'F', 'asasfsdfg', '0001', 'asgadgs', 'asfsdgsfg');";
                
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();

                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {

                }
                MyConn2.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
