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
            this.StartDtp = new System.Windows.Forms.DateTimePicker();
            this.FinishDtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddProjectBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AddedEmployeesLbx = new System.Windows.Forms.ListBox();
            this.EmployeesToAddLbx = new System.Windows.Forms.ListBox();
            this.WorkingHoursTxt = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
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
            // StartDtp
            // 
            this.StartDtp.Location = new System.Drawing.Point(138, 91);
            this.StartDtp.Name = "StartDtp";
            this.StartDtp.Size = new System.Drawing.Size(200, 20);
            this.StartDtp.TabIndex = 4;
            // 
            // FinishDtp
            // 
            this.FinishDtp.Location = new System.Drawing.Point(138, 178);
            this.FinishDtp.Name = "FinishDtp";
            this.FinishDtp.Size = new System.Drawing.Size(200, 20);
            this.FinishDtp.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Starting date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estimated time of finishing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Choose the employees for the project:";
            // 
            // AddProjectBtn
            // 
            this.AddProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjectBtn.Location = new System.Drawing.Point(25, 456);
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
            this.ExitBtn.Location = new System.Drawing.Point(319, 456);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(155, 64);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddedEmployeesLbx
            // 
            this.AddedEmployeesLbx.FormattingEnabled = true;
            this.AddedEmployeesLbx.Location = new System.Drawing.Point(302, 259);
            this.AddedEmployeesLbx.Name = "AddedEmployeesLbx";
            this.AddedEmployeesLbx.Size = new System.Drawing.Size(189, 173);
            this.AddedEmployeesLbx.TabIndex = 12;
            // 
            // EmployeesToAddLbx
            // 
            this.EmployeesToAddLbx.FormattingEnabled = true;
            this.EmployeesToAddLbx.Location = new System.Drawing.Point(16, 259);
            this.EmployeesToAddLbx.Name = "EmployeesToAddLbx";
            this.EmployeesToAddLbx.Size = new System.Drawing.Size(185, 173);
            this.EmployeesToAddLbx.TabIndex = 13;
            // 
            // WorkingHoursTxt
            // 
            this.WorkingHoursTxt.Location = new System.Drawing.Point(222, 276);
            this.WorkingHoursTxt.Name = "WorkingHoursTxt";
            this.WorkingHoursTxt.Size = new System.Drawing.Size(57, 20);
            this.WorkingHoursTxt.TabIndex = 14;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(213, 319);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 40);
            this.SaveBtn.TabIndex = 15;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 545);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.WorkingHoursTxt);
            this.Controls.Add(this.EmployeesToAddLbx);
            this.Controls.Add(this.AddedEmployeesLbx);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AddProjectBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FinishDtp);
            this.Controls.Add(this.StartDtp);
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
        private System.Windows.Forms.DateTimePicker StartDtp;
        private System.Windows.Forms.DateTimePicker FinishDtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddProjectBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ListBox AddedEmployeesLbx;
        private System.Windows.Forms.ListBox EmployeesToAddLbx;
        private System.Windows.Forms.TextBox WorkingHoursTxt;
        private System.Windows.Forms.Button SaveBtn;
    }
}