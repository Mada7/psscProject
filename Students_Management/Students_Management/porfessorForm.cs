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
        partial class porfessorForm : Form
    {
        public porfessorForm()
        {
            InitializeComponent();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            Professor prof = new Professor();
            prof.submitGrades();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
