namespace Internship_4_Employees
{
    partial class EditProject
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.EditProjectBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FinishDtp = new System.Windows.Forms.DateTimePicker();
            this.StartDtp = new System.Windows.Forms.DateTimePicker();
            this.ProjectNameLbl = new System.Windows.Forms.Label();
            this.EmployeesNotWorkingOnProjectLbx = new System.Windows.Forms.ListBox();
            this.EmployeesWorkingOnPojectLbx = new System.Windows.Forms.ListBox();
            this.EmployeesNotWorkingOnProjectLbl = new System.Windows.Forms.Label();
            this.EmployeesToAddLbl = new System.Windows.Forms.Label();
            this.AddToProjectbtn = new System.Windows.Forms.Button();
            this.RemoveFromProjectBtn = new System.Windows.Forms.Button();
            this.WorkingHoursTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(253, 529);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(155, 64);
            this.ExitBtn.TabIndex = 21;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // EditProjectBtn
            // 
            this.EditProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProjectBtn.Location = new System.Drawing.Point(49, 529);
            this.EditProjectBtn.Name = "EditProjectBtn";
            this.EditProjectBtn.Size = new System.Drawing.Size(155, 64);
            this.EditProjectBtn.TabIndex = 20;
            this.EditProjectBtn.Text = "Edit Project";
            this.EditProjectBtn.UseVisualStyleBackColor = true;
            this.EditProjectBtn.Click += new System.EventHandler(this.EditProjectBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Choose the employees for the project:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(139, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Estimated time of finishing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Starting date";
            // 
            // FinishDtp
            // 
            this.FinishDtp.Location = new System.Drawing.Point(134, 187);
            this.FinishDtp.Name = "FinishDtp";
            this.FinishDtp.Size = new System.Drawing.Size(200, 20);
            this.FinishDtp.TabIndex = 15;
            // 
            // StartDtp
            // 
            this.StartDtp.Location = new System.Drawing.Point(134, 100);
            this.StartDtp.Name = "StartDtp";
            this.StartDtp.Size = new System.Drawing.Size(200, 20);
            this.StartDtp.TabIndex = 14;
            // 
            // ProjectNameLbl
            // 
            this.ProjectNameLbl.AutoSize = true;
            this.ProjectNameLbl.Location = new System.Drawing.Point(172, 27);
            this.ProjectNameLbl.Name = "ProjectNameLbl";
            this.ProjectNameLbl.Size = new System.Drawing.Size(0, 13);
            this.ProjectNameLbl.TabIndex = 22;
            // 
            // EmployeesNotWorkingOnProjectLbx
            // 
            this.EmployeesNotWorkingOnProjectLbx.FormattingEnabled = true;
            this.EmployeesNotWorkingOnProjectLbx.Location = new System.Drawing.Point(12, 298);
            this.EmployeesNotWorkingOnProjectLbx.Name = "EmployeesNotWorkingOnProjectLbx";
            this.EmployeesNotWorkingOnProjectLbx.Size = new System.Drawing.Size(160, 212);
            this.EmployeesNotWorkingOnProjectLbx.TabIndex = 23;
            // 
            // EmployeesWorkingOnPojectLbx
            // 
            this.EmployeesWorkingOnPojectLbx.FormattingEnabled = true;
            this.EmployeesWorkingOnPojectLbx.Location = new System.Drawing.Point(287, 298);
            this.EmployeesWorkingOnPojectLbx.Name = "EmployeesWorkingOnPojectLbx";
            this.EmployeesWorkingOnPojectLbx.Size = new System.Drawing.Size(166, 212);
            this.EmployeesWorkingOnPojectLbx.TabIndex = 24;
            // 
            // EmployeesNotWorkingOnProjectLbl
            // 
            this.EmployeesNotWorkingOnProjectLbl.AutoSize = true;
            this.EmployeesNotWorkingOnProjectLbl.Location = new System.Drawing.Point(284, 271);
            this.EmployeesNotWorkingOnProjectLbl.Name = "EmployeesNotWorkingOnProjectLbl";
            this.EmployeesNotWorkingOnProjectLbl.Size = new System.Drawing.Size(148, 13);
            this.EmployeesNotWorkingOnProjectLbl.TabIndex = 25;
            this.EmployeesNotWorkingOnProjectLbl.Text = "Employees working on project";
            // 
            // EmployeesToAddLbl
            // 
            this.EmployeesToAddLbl.AutoSize = true;
            this.EmployeesToAddLbl.Location = new System.Drawing.Point(12, 271);
            this.EmployeesToAddLbl.Name = "EmployeesToAddLbl";
            this.EmployeesToAddLbl.Size = new System.Drawing.Size(166, 13);
            this.EmployeesToAddLbl.TabIndex = 26;
            this.EmployeesToAddLbl.Text = "Employees not working on project";
            // 
            // AddToProjectbtn
            // 
            this.AddToProjectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToProjectbtn.Location = new System.Drawing.Point(187, 314);
            this.AddToProjectbtn.Name = "AddToProjectbtn";
            this.AddToProjectbtn.Size = new System.Drawing.Size(84, 43);
            this.AddToProjectbtn.TabIndex = 27;
            this.AddToProjectbtn.Text = "Add";
            this.AddToProjectbtn.UseVisualStyleBackColor = true;
            this.AddToProjectbtn.Click += new System.EventHandler(this.AddToProjectbtn_Click);
            // 
            // RemoveFromProjectBtn
            // 
            this.RemoveFromProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFromProjectBtn.Location = new System.Drawing.Point(187, 409);
            this.RemoveFromProjectBtn.Name = "RemoveFromProjectBtn";
            this.RemoveFromProjectBtn.Size = new System.Drawing.Size(84, 45);
            this.RemoveFromProjectBtn.TabIndex = 28;
            this.RemoveFromProjectBtn.Text = "Remove";
            this.RemoveFromProjectBtn.UseVisualStyleBackColor = true;
            this.RemoveFromProjectBtn.Click += new System.EventHandler(this.RemoveFromProjectBtn_Click);
            // 
            // WorkingHoursTxt
            // 
            this.WorkingHoursTxt.Location = new System.Drawing.Point(204, 373);
            this.WorkingHoursTxt.Name = "WorkingHoursTxt";
            this.WorkingHoursTxt.Size = new System.Drawing.Size(48, 20);
            this.WorkingHoursTxt.TabIndex = 29;
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 605);
            this.Controls.Add(this.WorkingHoursTxt);
            this.Controls.Add(this.RemoveFromProjectBtn);
            this.Controls.Add(this.AddToProjectbtn);
            this.Controls.Add(this.EmployeesToAddLbl);
            this.Controls.Add(this.EmployeesNotWorkingOnProjectLbl);
            this.Controls.Add(this.EmployeesWorkingOnPojectLbx);
            this.Controls.Add(this.EmployeesNotWorkingOnProjectLbx);
            this.Controls.Add(this.ProjectNameLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EditProjectBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FinishDtp);
            this.Controls.Add(this.StartDtp);
            this.Name = "EditProject";
            this.Text = "EditProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button EditProjectBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FinishDtp;
        private System.Windows.Forms.DateTimePicker StartDtp;
        private System.Windows.Forms.Label ProjectNameLbl;
        private System.Windows.Forms.ListBox EmployeesNotWorkingOnProjectLbx;
        private System.Windows.Forms.ListBox EmployeesWorkingOnPojectLbx;
        private System.Windows.Forms.Label EmployeesNotWorkingOnProjectLbl;
        private System.Windows.Forms.Label EmployeesToAddLbl;
        private System.Windows.Forms.Button AddToProjectbtn;
        private System.Windows.Forms.Button RemoveFromProjectBtn;
        private System.Windows.Forms.TextBox WorkingHoursTxt;
    }
}