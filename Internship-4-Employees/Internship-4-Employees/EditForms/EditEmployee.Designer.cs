namespace Internship_4_Employees
{
    partial class EditEmployee
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
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.LastnameTbx = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.LastnameLbl = new System.Windows.Forms.Label();
            this.DateOfBirthLbl = new System.Windows.Forms.Label();
            this.PositionsCmb = new System.Windows.Forms.ComboBox();
            this.DateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.EmployeeOIBLbl = new System.Windows.Forms.Label();
            this.ProjectsEmployeeIsOnLbx = new System.Windows.Forms.ListBox();
            this.ProjectsEmployeeIsNotOnLbx = new System.Windows.Forms.ListBox();
            this.WorkingHoursTxt = new System.Windows.Forms.TextBox();
            this.RemoveFromProjectBtn = new System.Windows.Forms.Button();
            this.AddToProjectbtn = new System.Windows.Forms.Button();
            this.ProjectsToAddLbl = new System.Windows.Forms.Label();
            this.ProjectsEmployeeIsWorkingOnLbl = new System.Windows.Forms.Label();
            this.PositionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameTbx
            // 
            this.NameTbx.Location = new System.Drawing.Point(144, 65);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(159, 20);
            this.NameTbx.TabIndex = 0;
            // 
            // LastnameTbx
            // 
            this.LastnameTbx.Location = new System.Drawing.Point(144, 107);
            this.LastnameTbx.Name = "LastnameTbx";
            this.LastnameTbx.Size = new System.Drawing.Size(159, 20);
            this.LastnameTbx.TabIndex = 1;
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(27, 65);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(55, 20);
            this.NameLbl.TabIndex = 2;
            this.NameLbl.Text = "Name:";
            // 
            // LastnameLbl
            // 
            this.LastnameLbl.AutoSize = true;
            this.LastnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastnameLbl.Location = new System.Drawing.Point(27, 107);
            this.LastnameLbl.Name = "LastnameLbl";
            this.LastnameLbl.Size = new System.Drawing.Size(84, 20);
            this.LastnameLbl.TabIndex = 3;
            this.LastnameLbl.Text = "Lastname:";
            // 
            // DateOfBirthLbl
            // 
            this.DateOfBirthLbl.AutoSize = true;
            this.DateOfBirthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthLbl.Location = new System.Drawing.Point(27, 151);
            this.DateOfBirthLbl.Name = "DateOfBirthLbl";
            this.DateOfBirthLbl.Size = new System.Drawing.Size(101, 20);
            this.DateOfBirthLbl.TabIndex = 4;
            this.DateOfBirthLbl.Text = "Date of birth:";
            // 
            // PositionsCmb
            // 
            this.PositionsCmb.FormattingEnabled = true;
            this.PositionsCmb.Location = new System.Drawing.Point(144, 192);
            this.PositionsCmb.Name = "PositionsCmb";
            this.PositionsCmb.Size = new System.Drawing.Size(243, 21);
            this.PositionsCmb.TabIndex = 13;
            // 
            // DateOfBirthPicker
            // 
            this.DateOfBirthPicker.Location = new System.Drawing.Point(144, 151);
            this.DateOfBirthPicker.Name = "DateOfBirthPicker";
            this.DateOfBirthPicker.Size = new System.Drawing.Size(243, 20);
            this.DateOfBirthPicker.TabIndex = 11;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(24, 447);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(186, 64);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(312, 447);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(186, 64);
            this.ExitBtn.TabIndex = 15;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // EmployeeOIBLbl
            // 
            this.EmployeeOIBLbl.AutoSize = true;
            this.EmployeeOIBLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeOIBLbl.Location = new System.Drawing.Point(35, 30);
            this.EmployeeOIBLbl.Name = "EmployeeOIBLbl";
            this.EmployeeOIBLbl.Size = new System.Drawing.Size(0, 24);
            this.EmployeeOIBLbl.TabIndex = 16;
            // 
            // ProjectsEmployeeIsOnLbx
            // 
            this.ProjectsEmployeeIsOnLbx.FormattingEnabled = true;
            this.ProjectsEmployeeIsOnLbx.Location = new System.Drawing.Point(312, 268);
            this.ProjectsEmployeeIsOnLbx.Name = "ProjectsEmployeeIsOnLbx";
            this.ProjectsEmployeeIsOnLbx.Size = new System.Drawing.Size(186, 173);
            this.ProjectsEmployeeIsOnLbx.TabIndex = 17;
            // 
            // ProjectsEmployeeIsNotOnLbx
            // 
            this.ProjectsEmployeeIsNotOnLbx.FormattingEnabled = true;
            this.ProjectsEmployeeIsNotOnLbx.Location = new System.Drawing.Point(24, 268);
            this.ProjectsEmployeeIsNotOnLbx.Name = "ProjectsEmployeeIsNotOnLbx";
            this.ProjectsEmployeeIsNotOnLbx.Size = new System.Drawing.Size(186, 173);
            this.ProjectsEmployeeIsNotOnLbx.TabIndex = 18;
            // 
            // WorkingHoursTxt
            // 
            this.WorkingHoursTxt.Location = new System.Drawing.Point(236, 347);
            this.WorkingHoursTxt.Name = "WorkingHoursTxt";
            this.WorkingHoursTxt.Size = new System.Drawing.Size(48, 20);
            this.WorkingHoursTxt.TabIndex = 32;
            // 
            // RemoveFromProjectBtn
            // 
            this.RemoveFromProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveFromProjectBtn.Location = new System.Drawing.Point(219, 383);
            this.RemoveFromProjectBtn.Name = "RemoveFromProjectBtn";
            this.RemoveFromProjectBtn.Size = new System.Drawing.Size(84, 45);
            this.RemoveFromProjectBtn.TabIndex = 31;
            this.RemoveFromProjectBtn.Text = "Remove";
            this.RemoveFromProjectBtn.UseVisualStyleBackColor = true;
            this.RemoveFromProjectBtn.Click += new System.EventHandler(this.RemoveFromProjectBtn_Click);
            // 
            // AddToProjectbtn
            // 
            this.AddToProjectbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToProjectbtn.Location = new System.Drawing.Point(219, 288);
            this.AddToProjectbtn.Name = "AddToProjectbtn";
            this.AddToProjectbtn.Size = new System.Drawing.Size(84, 43);
            this.AddToProjectbtn.TabIndex = 30;
            this.AddToProjectbtn.Text = "Add";
            this.AddToProjectbtn.UseVisualStyleBackColor = true;
            this.AddToProjectbtn.Click += new System.EventHandler(this.AddToProjectbtn_Click);
            // 
            // ProjectsToAddLbl
            // 
            this.ProjectsToAddLbl.AutoSize = true;
            this.ProjectsToAddLbl.Location = new System.Drawing.Point(34, 241);
            this.ProjectsToAddLbl.Name = "ProjectsToAddLbl";
            this.ProjectsToAddLbl.Size = new System.Drawing.Size(176, 13);
            this.ProjectsToAddLbl.TabIndex = 34;
            this.ProjectsToAddLbl.Text = "Projects employee is not working on";
            // 
            // ProjectsEmployeeIsWorkingOnLbl
            // 
            this.ProjectsEmployeeIsWorkingOnLbl.AutoSize = true;
            this.ProjectsEmployeeIsWorkingOnLbl.Location = new System.Drawing.Point(333, 241);
            this.ProjectsEmployeeIsWorkingOnLbl.Name = "ProjectsEmployeeIsWorkingOnLbl";
            this.ProjectsEmployeeIsWorkingOnLbl.Size = new System.Drawing.Size(158, 13);
            this.ProjectsEmployeeIsWorkingOnLbl.TabIndex = 33;
            this.ProjectsEmployeeIsWorkingOnLbl.Text = "Projects employee is working on";
            // 
            // PositionLbl
            // 
            this.PositionLbl.AutoSize = true;
            this.PositionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLbl.Location = new System.Drawing.Point(27, 193);
            this.PositionLbl.Name = "PositionLbl";
            this.PositionLbl.Size = new System.Drawing.Size(109, 20);
            this.PositionLbl.TabIndex = 35;
            this.PositionLbl.Text = "Position (Job):";
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 523);
            this.Controls.Add(this.PositionLbl);
            this.Controls.Add(this.ProjectsToAddLbl);
            this.Controls.Add(this.ProjectsEmployeeIsWorkingOnLbl);
            this.Controls.Add(this.WorkingHoursTxt);
            this.Controls.Add(this.RemoveFromProjectBtn);
            this.Controls.Add(this.AddToProjectbtn);
            this.Controls.Add(this.ProjectsEmployeeIsNotOnLbx);
            this.Controls.Add(this.ProjectsEmployeeIsOnLbx);
            this.Controls.Add(this.EmployeeOIBLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.PositionsCmb);
            this.Controls.Add(this.DateOfBirthPicker);
            this.Controls.Add(this.DateOfBirthLbl);
            this.Controls.Add(this.LastnameLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.LastnameTbx);
            this.Controls.Add(this.NameTbx);
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTbx;
        private System.Windows.Forms.TextBox LastnameTbx;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label LastnameLbl;
        private System.Windows.Forms.Label DateOfBirthLbl;
        private System.Windows.Forms.ComboBox PositionsCmb;
        private System.Windows.Forms.DateTimePicker DateOfBirthPicker;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label EmployeeOIBLbl;
        private System.Windows.Forms.ListBox ProjectsEmployeeIsOnLbx;
        private System.Windows.Forms.ListBox ProjectsEmployeeIsNotOnLbx;
        private System.Windows.Forms.TextBox WorkingHoursTxt;
        private System.Windows.Forms.Button RemoveFromProjectBtn;
        private System.Windows.Forms.Button AddToProjectbtn;
        private System.Windows.Forms.Label ProjectsToAddLbl;
        private System.Windows.Forms.Label ProjectsEmployeeIsWorkingOnLbl;
        private System.Windows.Forms.Label PositionLbl;
    }
}