﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Students_Management
{
    public partial class AddForm  : Form
   {
        public AddForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

    }
}
