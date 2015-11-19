namespace Students_Management
{
    partial class porfessorForm
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
            this.submit_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.studentSearch_label = new System.Windows.Forms.Label();
            this.studSearch_textBox = new System.Windows.Forms.TextBox();
            this.examGrd_label = new System.Windows.Forms.Label();
            this.actGrd_label = new System.Windows.Forms.Label();
            this.coef_label = new System.Windows.Forms.Label();
            this.exam_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.activity_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.coef_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.courseName_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.exam_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activity_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coef_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(255, 288);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(134, 32);
            this.submit_button.TabIndex = 0;
            this.submit_button.Text = "Submit grades";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(13, 297);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 1;
            this.close_button.Text = "Close";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // studentSearch_label
            // 
            this.studentSearch_label.AutoSize = true;
            this.studentSearch_label.Location = new System.Drawing.Point(10, 45);
            this.studentSearch_label.Name = "studentSearch_label";
            this.studentSearch_label.Size = new System.Drawing.Size(98, 17);
            this.studentSearch_label.TabIndex = 2;
            this.studentSearch_label.Text = "Student Name";
            // 
            // studSearch_textBox
            // 
            this.studSearch_textBox.Location = new System.Drawing.Point(114, 45);
            this.studSearch_textBox.Name = "studSearch_textBox";
            this.studSearch_textBox.ShortcutsEnabled = false;
            this.studSearch_textBox.Size = new System.Drawing.Size(181, 22);
            this.studSearch_textBox.TabIndex = 3;
            // 
            // examGrd_label
            // 
            this.examGrd_label.AutoSize = true;
            this.examGrd_label.Location = new System.Drawing.Point(22, 141);
            this.examGrd_label.Name = "examGrd_label";
            this.examGrd_label.Size = new System.Drawing.Size(86, 17);
            this.examGrd_label.TabIndex = 4;
            this.examGrd_label.Text = "Exam Grade";
            // 
            // actGrd_label
            // 
            this.actGrd_label.AutoSize = true;
            this.actGrd_label.Location = new System.Drawing.Point(14, 171);
            this.actGrd_label.Name = "actGrd_label";
            this.actGrd_label.Size = new System.Drawing.Size(96, 17);
            this.actGrd_label.TabIndex = 5;
            this.actGrd_label.Text = "Activity Grade";
            // 
            // coef_label
            // 
            this.coef_label.AutoSize = true;
            this.coef_label.Location = new System.Drawing.Point(38, 206);
            this.coef_label.Name = "coef_label";
            this.coef_label.Size = new System.Drawing.Size(70, 17);
            this.coef_label.TabIndex = 6;
            this.coef_label.Text = "Coeficient";
            // 
            // exam_numericUpDown
            // 
            this.exam_numericUpDown.Location = new System.Drawing.Point(114, 139);
            this.exam_numericUpDown.Name = "exam_numericUpDown";
            this.exam_numericUpDown.Size = new System.Drawing.Size(64, 22);
            this.exam_numericUpDown.TabIndex = 7;
            // 
            // activity_numericUpDown
            // 
            this.activity_numericUpDown.Location = new System.Drawing.Point(114, 169);
            this.activity_numericUpDown.Name = "activity_numericUpDown";
            this.activity_numericUpDown.Size = new System.Drawing.Size(64, 22);
            this.activity_numericUpDown.TabIndex = 8;
            // 
            // coef_numericUpDown
            // 
            this.coef_numericUpDown.Location = new System.Drawing.Point(114, 204);
            this.coef_numericUpDown.Name = "coef_numericUpDown";
            this.coef_numericUpDown.Size = new System.Drawing.Size(64, 22);
            this.coef_numericUpDown.TabIndex = 9;
            // 
            // courseName_textBox
            // 
            this.courseName_textBox.Location = new System.Drawing.Point(114, 83);
            this.courseName_textBox.Name = "courseName_textBox";
            this.courseName_textBox.ShortcutsEnabled = false;
            this.courseName_textBox.Size = new System.Drawing.Size(181, 22);
            this.courseName_textBox.TabIndex = 10;
            // 
            // porfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 332);
            this.Controls.Add(this.courseName_textBox);
            this.Controls.Add(this.coef_numericUpDown);
            this.Controls.Add(this.activity_numericUpDown);
            this.Controls.Add(this.exam_numericUpDown);
            this.Controls.Add(this.coef_label);
            this.Controls.Add(this.actGrd_label);
            this.Controls.Add(this.examGrd_label);
            this.Controls.Add(this.studSearch_textBox);
            this.Controls.Add(this.studentSearch_label);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.submit_button);
            this.Name = "porfessorForm";
            this.Text = "porfessorForm";
            ((System.ComponentModel.ISupportInitialize)(this.exam_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activity_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coef_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Label studentSearch_label;
        private System.Windows.Forms.TextBox studSearch_textBox;
        private System.Windows.Forms.Label examGrd_label;
        private System.Windows.Forms.Label actGrd_label;
        private System.Windows.Forms.Label coef_label;
        private System.Windows.Forms.NumericUpDown exam_numericUpDown;
        private System.Windows.Forms.NumericUpDown activity_numericUpDown;
        private System.Windows.Forms.NumericUpDown coef_numericUpDown;
        private System.Windows.Forms.TextBox courseName_textBox;
    }
}