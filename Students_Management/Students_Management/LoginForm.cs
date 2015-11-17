using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if(secretariat_radioButton.Checked)
            {
                AddForm addfrm = new AddForm();
                this.Hide();
                addfrm.Show();
            }

            if( prof_radioButton.Checked)
            {
                porfessorForm prof = new porfessorForm();
                this.Hide();
                prof.Show();
            }

            if(stud_radioButton.Checked)
            {
                studentForm stud = new studentForm();
                this.Hide();
                stud.Show();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
