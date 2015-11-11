namespace Students_Management
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addButton = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.regNo_textBox = new System.Windows.Forms.TextBox();
            this.phone_textBox = new System.Windows.Forms.TextBox();
            this.email_textBox = new System.Windows.Forms.TextBox();
            this.cnp_textBox = new System.Windows.Forms.TextBox();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.id_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.cnp_label = new System.Windows.Forms.Label();
            this.regNo_label = new System.Windows.Forms.Label();
            this.phoneNo_label = new System.Windows.Forms.Label();
            this.sex_label = new System.Windows.Forms.Label();
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(33, 399);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(114, 66);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(296, 22);
            this.name_textBox.TabIndex = 1;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(114, 94);
            this.address_textBox.Multiline = true;
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(296, 60);
            this.address_textBox.TabIndex = 2;
            // 
            // regNo_textBox
            // 
            this.regNo_textBox.Location = new System.Drawing.Point(114, 188);
            this.regNo_textBox.Name = "regNo_textBox";
            this.regNo_textBox.Size = new System.Drawing.Size(296, 22);
            this.regNo_textBox.TabIndex = 3;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(114, 216);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(296, 22);
            this.phone_textBox.TabIndex = 4;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(114, 244);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(296, 22);
            this.email_textBox.TabIndex = 5;
            // 
            // cnp_textBox
            // 
            this.cnp_textBox.Location = new System.Drawing.Point(114, 160);
            this.cnp_textBox.Name = "cnp_textBox";
            this.cnp_textBox.Size = new System.Drawing.Size(296, 22);
            this.cnp_textBox.TabIndex = 6;
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_comboBox.Location = new System.Drawing.Point(114, 272);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(87, 24);
            this.gender_comboBox.TabIndex = 7;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(87, 41);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(21, 17);
            this.id_label.TabIndex = 8;
            this.id_label.Text = "ID";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(63, 69);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(45, 17);
            this.name_label.TabIndex = 9;
            this.name_label.Text = "Name";
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Location = new System.Drawing.Point(48, 97);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(60, 17);
            this.address_label.TabIndex = 10;
            this.address_label.Text = "Address";
            // 
            // cnp_label
            // 
            this.cnp_label.AutoSize = true;
            this.cnp_label.Location = new System.Drawing.Point(72, 163);
            this.cnp_label.Name = "cnp_label";
            this.cnp_label.Size = new System.Drawing.Size(36, 17);
            this.cnp_label.TabIndex = 11;
            this.cnp_label.Text = "CNP";
            // 
            // regNo_label
            // 
            this.regNo_label.AutoSize = true;
            this.regNo_label.Location = new System.Drawing.Point(-2, 191);
            this.regNo_label.Name = "regNo_label";
            this.regNo_label.Size = new System.Drawing.Size(110, 17);
            this.regNo_label.TabIndex = 12;
            this.regNo_label.Text = "Registration No.";
            // 
            // phoneNo_label
            // 
            this.phoneNo_label.AutoSize = true;
            this.phoneNo_label.Location = new System.Drawing.Point(33, 219);
            this.phoneNo_label.Name = "phoneNo_label";
            this.phoneNo_label.Size = new System.Drawing.Size(75, 17);
            this.phoneNo_label.TabIndex = 13;
            this.phoneNo_label.Text = "Phone No.";
            // 
            // sex_label
            // 
            this.sex_label.AutoSize = true;
            this.sex_label.Location = new System.Drawing.Point(77, 275);
            this.sex_label.Name = "sex_label";
            this.sex_label.Size = new System.Drawing.Size(31, 17);
            this.sex_label.TabIndex = 14;
            this.sex_label.Text = "Sex";
            // 
            // ID_textBox
            // 
            this.ID_textBox.Location = new System.Drawing.Point(114, 38);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(37, 22);
            this.ID_textBox.TabIndex = 15;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(66, 247);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(42, 17);
            this.email_label.TabIndex = 16;
            this.email_label.Text = "Email";
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(157, 399);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 17;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 434);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.sex_label);
            this.Controls.Add(this.phoneNo_label);
            this.Controls.Add(this.regNo_label);
            this.Controls.Add(this.cnp_label);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.gender_comboBox);
            this.Controls.Add(this.cnp_textBox);
            this.Controls.Add(this.email_textBox);
            this.Controls.Add(this.phone_textBox);
            this.Controls.Add(this.regNo_textBox);
            this.Controls.Add(this.address_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.addButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.TextBox regNo_textBox;
        private System.Windows.Forms.TextBox phone_textBox;
        private System.Windows.Forms.TextBox email_textBox;
        private System.Windows.Forms.TextBox cnp_textBox;
        private System.Windows.Forms.ComboBox gender_comboBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.Label cnp_label;
        private System.Windows.Forms.Label regNo_label;
        private System.Windows.Forms.Label phoneNo_label;
        private System.Windows.Forms.Label sex_label;
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Button cancel_button;
    }
}

