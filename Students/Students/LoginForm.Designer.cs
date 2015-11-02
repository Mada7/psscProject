namespace Students
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
            this.user_label = new System.Windows.Forms.Label();
            this.passwd_label = new System.Windows.Forms.Label();
            this.user_textBox = new System.Windows.Forms.TextBox();
            this.passwd_textBox = new System.Windows.Forms.TextBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(23, 44);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(77, 17);
            this.user_label.TabIndex = 0;
            this.user_label.Text = "Username:";
            // 
            // passwd_label
            // 
            this.passwd_label.AutoSize = true;
            this.passwd_label.Location = new System.Drawing.Point(23, 126);
            this.passwd_label.Name = "passwd_label";
            this.passwd_label.Size = new System.Drawing.Size(73, 17);
            this.passwd_label.TabIndex = 1;
            this.passwd_label.Text = "Password:";
            // 
            // user_textBox
            // 
            this.user_textBox.Location = new System.Drawing.Point(26, 64);
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.Size = new System.Drawing.Size(288, 22);
            this.user_textBox.TabIndex = 2;
            // 
            // passwd_textBox
            // 
            this.passwd_textBox.Location = new System.Drawing.Point(26, 146);
            this.passwd_textBox.Name = "passwd_textBox";
            this.passwd_textBox.Size = new System.Drawing.Size(288, 22);
            this.passwd_textBox.TabIndex = 3;
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(26, 211);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(93, 42);
            this.OK_button.TabIndex = 4;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(221, 211);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(93, 42);
            this.Cancel_button.TabIndex = 5;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 283);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.passwd_textBox);
            this.Controls.Add(this.user_textBox);
            this.Controls.Add(this.passwd_label);
            this.Controls.Add(this.user_label);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label passwd_label;
        private System.Windows.Forms.TextBox user_textBox;
        private System.Windows.Forms.TextBox passwd_textBox;
        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}