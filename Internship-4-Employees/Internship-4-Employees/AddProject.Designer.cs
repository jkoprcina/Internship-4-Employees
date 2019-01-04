namespace Internship_4_Employees
{
    partial class AddProject
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
            this.ProjectNameTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HoursTbx = new System.Windows.Forms.TextBox();
            this.StartDtp = new System.Windows.Forms.DateTimePicker();
            this.FinishingDtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeCbx = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddProjectBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjectNameTbx
            // 
            this.ProjectNameTbx.Location = new System.Drawing.Point(138, 21);
            this.ProjectNameTbx.Name = "ProjectNameTbx";
            this.ProjectNameTbx.Size = new System.Drawing.Size(227, 20);
            this.ProjectNameTbx.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of hours per week each person \r\nassigned to the project will work on it:";
            // 
            // HoursTbx
            // 
            this.HoursTbx.Location = new System.Drawing.Point(321, 77);
            this.HoursTbx.Name = "HoursTbx";
            this.HoursTbx.Size = new System.Drawing.Size(44, 20);
            this.HoursTbx.TabIndex = 3;
            // 
            // StartDtp
            // 
            this.StartDtp.Location = new System.Drawing.Point(103, 180);
            this.StartDtp.Name = "StartDtp";
            this.StartDtp.Size = new System.Drawing.Size(200, 20);
            this.StartDtp.TabIndex = 4;
            // 
            // FinishingDtp
            // 
            this.FinishingDtp.Location = new System.Drawing.Point(103, 267);
            this.FinishingDtp.Name = "FinishingDtp";
            this.FinishingDtp.Size = new System.Drawing.Size(200, 20);
            this.FinishingDtp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Starting date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estimated time of finishing";
            // 
            // EmployeeCbx
            // 
            this.EmployeeCbx.FormattingEnabled = true;
            this.EmployeeCbx.Location = new System.Drawing.Point(73, 346);
            this.EmployeeCbx.Name = "EmployeeCbx";
            this.EmployeeCbx.Size = new System.Drawing.Size(252, 184);
            this.EmployeeCbx.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Choose the employees for the project:";
            // 
            // AddProjectBtn
            // 
            this.AddProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjectBtn.Location = new System.Drawing.Point(31, 546);
            this.AddProjectBtn.Name = "AddProjectBtn";
            this.AddProjectBtn.Size = new System.Drawing.Size(147, 64);
            this.AddProjectBtn.TabIndex = 10;
            this.AddProjectBtn.Text = "Add Project";
            this.AddProjectBtn.UseVisualStyleBackColor = true;
            this.AddProjectBtn.Click += new System.EventHandler(this.AddProjectBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(210, 546);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(155, 64);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 637);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddProjectBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EmployeeCbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FinishingDtp);
            this.Controls.Add(this.StartDtp);
            this.Controls.Add(this.HoursTbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectNameTbx);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjectNameTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HoursTbx;
        private System.Windows.Forms.DateTimePicker StartDtp;
        private System.Windows.Forms.DateTimePicker FinishingDtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox EmployeeCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddProjectBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}