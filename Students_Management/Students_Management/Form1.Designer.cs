namespace Students_Management
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(66, 245);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(86, 38);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(100, 22);
            this.name_textBox.TabIndex = 1;
            // 
            // address_textBox
            // 
            this.address_textBox.Location = new System.Drawing.Point(86, 93);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(100, 22);
            this.address_textBox.TabIndex = 2;
            // 
            // regNo_textBox
            // 
            this.regNo_textBox.Location = new System.Drawing.Point(86, 65);
            this.regNo_textBox.Name = "regNo_textBox";
            this.regNo_textBox.Size = new System.Drawing.Size(100, 22);
            this.regNo_textBox.TabIndex = 3;
            // 
            // phone_textBox
            // 
            this.phone_textBox.Location = new System.Drawing.Point(86, 121);
            this.phone_textBox.Name = "phone_textBox";
            this.phone_textBox.Size = new System.Drawing.Size(100, 22);
            this.phone_textBox.TabIndex = 4;
            // 
            // email_textBox
            // 
            this.email_textBox.Location = new System.Drawing.Point(86, 149);
            this.email_textBox.Name = "email_textBox";
            this.email_textBox.Size = new System.Drawing.Size(100, 22);
            this.email_textBox.TabIndex = 5;
            // 
            // cnp_textBox
            // 
            this.cnp_textBox.Location = new System.Drawing.Point(86, 177);
            this.cnp_textBox.Name = "cnp_textBox";
            this.cnp_textBox.Size = new System.Drawing.Size(100, 22);
            this.cnp_textBox.TabIndex = 6;
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_comboBox.Location = new System.Drawing.Point(86, 205);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(121, 24);
            this.gender_comboBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 318);
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
    }
}

