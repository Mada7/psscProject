namespace Students_Management
{
    partial class LoginForm
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
            this.prof_radioButton = new System.Windows.Forms.RadioButton();
            this.stud_radioButton = new System.Windows.Forms.RadioButton();
            this.secretariat_radioButton = new System.Windows.Forms.RadioButton();
            this.user_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prof_radioButton
            // 
            this.prof_radioButton.AutoSize = true;
            this.prof_radioButton.Location = new System.Drawing.Point(156, 103);
            this.prof_radioButton.Name = "prof_radioButton";
            this.prof_radioButton.Size = new System.Drawing.Size(90, 21);
            this.prof_radioButton.TabIndex = 2;
            this.prof_radioButton.TabStop = true;
            this.prof_radioButton.Text = "Professor";
            this.prof_radioButton.UseVisualStyleBackColor = true;
            // 
            // stud_radioButton
            // 
            this.stud_radioButton.AutoSize = true;
            this.stud_radioButton.Location = new System.Drawing.Point(156, 130);
            this.stud_radioButton.Name = "stud_radioButton";
            this.stud_radioButton.Size = new System.Drawing.Size(78, 21);
            this.stud_radioButton.TabIndex = 3;
            this.stud_radioButton.TabStop = true;
            this.stud_radioButton.Text = "Student";
            this.stud_radioButton.UseVisualStyleBackColor = true;
            // 
            // secretariat_radioButton
            // 
            this.secretariat_radioButton.AutoSize = true;
            this.secretariat_radioButton.Location = new System.Drawing.Point(156, 157);
            this.secretariat_radioButton.Name = "secretariat_radioButton";
            this.secretariat_radioButton.Size = new System.Drawing.Size(90, 21);
            this.secretariat_radioButton.TabIndex = 4;
            this.secretariat_radioButton.TabStop = true;
            this.secretariat_radioButton.Text = "Secretary";
            this.secretariat_radioButton.UseVisualStyleBackColor = true;
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(63, 107);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(78, 17);
            this.user_label.TabIndex = 7;
            this.user_label.Text = "User Type:";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(249, 285);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 8;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(33, 285);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 320);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.secretariat_radioButton);
            this.Controls.Add(this.stud_radioButton);
            this.Controls.Add(this.prof_radioButton);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton prof_radioButton;
        private System.Windows.Forms.RadioButton stud_radioButton;
        private System.Windows.Forms.RadioButton secretariat_radioButton;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
    }
}