namespace Internship_4_Employees
{
    partial class MainPage
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
            this.AllEmployeesLbx = new System.Windows.Forms.ListBox();
            this.AllProjectsLbx = new System.Windows.Forms.ListBox();
            this.AllEmployeesLbl = new System.Windows.Forms.Label();
            this.AllProjectsLbl = new System.Windows.Forms.Label();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.ShutDownBtn = new System.Windows.Forms.Button();
            this.RemoveProjectBtn = new System.Windows.Forms.Button();
            this.RemoveEmployeeBtn = new System.Windows.Forms.Button();
            this.AddProjectBtn = new System.Windows.Forms.Button();
            this.EmployeeDetailsBtn = new System.Windows.Forms.Button();
            this.ProjectDetailsBtn = new System.Windows.Forms.Button();
            this.EditEmployeeBtn = new System.Windows.Forms.Button();
            this.EditProjectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllEmployeesLbx
            // 
            this.AllEmployeesLbx.FormattingEnabled = true;
            this.AllEmployeesLbx.Location = new System.Drawing.Point(12, 44);
            this.AllEmployeesLbx.Name = "AllEmployeesLbx";
            this.AllEmployeesLbx.Size = new System.Drawing.Size(201, 342);
            this.AllEmployeesLbx.TabIndex = 0;
            // 
            // AllProjectsLbx
            // 
            this.AllProjectsLbx.FormattingEnabled = true;
            this.AllProjectsLbx.Location = new System.Drawing.Point(228, 44);
            this.AllProjectsLbx.Name = "AllProjectsLbx";
            this.AllProjectsLbx.Size = new System.Drawing.Size(203, 342);
            this.AllProjectsLbx.TabIndex = 1;
            // 
            // AllEmployeesLbl
            // 
            this.AllEmployeesLbl.AutoSize = true;
            this.AllEmployeesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllEmployeesLbl.Location = new System.Drawing.Point(62, 13);
            this.AllEmployeesLbl.Name = "AllEmployeesLbl";
            this.AllEmployeesLbl.Size = new System.Drawing.Size(108, 20);
            this.AllEmployeesLbl.TabIndex = 2;
            this.AllEmployeesLbl.Text = "All Employees";
            // 
            // AllProjectsLbl
            // 
            this.AllProjectsLbl.AutoSize = true;
            this.AllProjectsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProjectsLbl.Location = new System.Drawing.Point(287, 13);
            this.AllProjectsLbl.Name = "AllProjectsLbl";
            this.AllProjectsLbl.Size = new System.Drawing.Size(87, 20);
            this.AllProjectsLbl.TabIndex = 3;
            this.AllProjectsLbl.Text = "All Projects";
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeBtn.Location = new System.Drawing.Point(457, 12);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(161, 60);
            this.AddEmployeeBtn.TabIndex = 4;
            this.AddEmployeeBtn.Text = "Add Employee";
            this.AddEmployeeBtn.UseVisualStyleBackColor = true;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // ShutDownBtn
            // 
            this.ShutDownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShutDownBtn.Location = new System.Drawing.Point(457, 408);
            this.ShutDownBtn.Name = "ShutDownBtn";
            this.ShutDownBtn.Size = new System.Drawing.Size(161, 60);
            this.ShutDownBtn.TabIndex = 5;
            this.ShutDownBtn.Text = "Shut Down App";
            this.ShutDownBtn.UseVisualStyleBackColor = true;
            this.ShutDownBtn.Click += new System.EventHandler(this.ShutDownBtn_Click);
            // 
            // RemoveProjectBtn
            // 
            this.RemoveProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveProjectBtn.Location = new System.Drawing.Point(457, 210);
            this.RemoveProjectBtn.Name = "RemoveProjectBtn";
            this.RemoveProjectBtn.Size = new System.Drawing.Size(161, 60);
            this.RemoveProjectBtn.TabIndex = 6;
            this.RemoveProjectBtn.Text = "Remove Project";
            this.RemoveProjectBtn.UseVisualStyleBackColor = true;
            this.RemoveProjectBtn.Click += new System.EventHandler(this.RemoveProjectBtn_Click);
            // 
            // RemoveEmployeeBtn
            // 
            this.RemoveEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEmployeeBtn.Location = new System.Drawing.Point(457, 144);
            this.RemoveEmployeeBtn.Name = "RemoveEmployeeBtn";
            this.RemoveEmployeeBtn.Size = new System.Drawing.Size(161, 60);
            this.RemoveEmployeeBtn.TabIndex = 7;
            this.RemoveEmployeeBtn.Text = "Remove Employee";
            this.RemoveEmployeeBtn.UseVisualStyleBackColor = true;
            this.RemoveEmployeeBtn.Click += new System.EventHandler(this.RemoveEmployeeBtn_Click);
            // 
            // AddProjectBtn
            // 
            this.AddProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjectBtn.Location = new System.Drawing.Point(457, 78);
            this.AddProjectBtn.Name = "AddProjectBtn";
            this.AddProjectBtn.Size = new System.Drawing.Size(161, 60);
            this.AddProjectBtn.TabIndex = 8;
            this.AddProjectBtn.Text = "Add Project";
            this.AddProjectBtn.UseVisualStyleBackColor = true;
            this.AddProjectBtn.Click += new System.EventHandler(this.AddProjectBtn_Click);
            // 
            // EmployeeDetailsBtn
            // 
            this.EmployeeDetailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDetailsBtn.Location = new System.Drawing.Point(23, 408);
            this.EmployeeDetailsBtn.Name = "EmployeeDetailsBtn";
            this.EmployeeDetailsBtn.Size = new System.Drawing.Size(182, 60);
            this.EmployeeDetailsBtn.TabIndex = 9;
            this.EmployeeDetailsBtn.Text = "Employee Details";
            this.EmployeeDetailsBtn.UseVisualStyleBackColor = true;
            this.EmployeeDetailsBtn.Click += new System.EventHandler(this.EmployeeDetailsBtn_Click);
            // 
            // ProjectDetailsBtn
            // 
            this.ProjectDetailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDetailsBtn.Location = new System.Drawing.Point(239, 408);
            this.ProjectDetailsBtn.Name = "ProjectDetailsBtn";
            this.ProjectDetailsBtn.Size = new System.Drawing.Size(182, 60);
            this.ProjectDetailsBtn.TabIndex = 10;
            this.ProjectDetailsBtn.Text = "ProjectDetails";
            this.ProjectDetailsBtn.UseVisualStyleBackColor = true;
            this.ProjectDetailsBtn.Click += new System.EventHandler(this.ProjectDetailsBtn_Click);
            // 
            // EditEmployeeBtn
            // 
            this.EditEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmployeeBtn.Location = new System.Drawing.Point(457, 276);
            this.EditEmployeeBtn.Name = "EditEmployeeBtn";
            this.EditEmployeeBtn.Size = new System.Drawing.Size(161, 60);
            this.EditEmployeeBtn.TabIndex = 11;
            this.EditEmployeeBtn.Text = "Edit Employee";
            this.EditEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // EditProjectBtn
            // 
            this.EditProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProjectBtn.Location = new System.Drawing.Point(457, 342);
            this.EditProjectBtn.Name = "EditProjectBtn";
            this.EditProjectBtn.Size = new System.Drawing.Size(161, 60);
            this.EditProjectBtn.TabIndex = 12;
            this.EditProjectBtn.Text = "Edit Project";
            this.EditProjectBtn.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 483);
            this.Controls.Add(this.EditProjectBtn);
            this.Controls.Add(this.EditEmployeeBtn);
            this.Controls.Add(this.ProjectDetailsBtn);
            this.Controls.Add(this.EmployeeDetailsBtn);
            this.Controls.Add(this.AddProjectBtn);
            this.Controls.Add(this.RemoveEmployeeBtn);
            this.Controls.Add(this.RemoveProjectBtn);
            this.Controls.Add(this.ShutDownBtn);
            this.Controls.Add(this.AddEmployeeBtn);
            this.Controls.Add(this.AllProjectsLbl);
            this.Controls.Add(this.AllEmployeesLbl);
            this.Controls.Add(this.AllProjectsLbx);
            this.Controls.Add(this.AllEmployeesLbx);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AllEmployeesLbx;
        private System.Windows.Forms.ListBox AllProjectsLbx;
        private System.Windows.Forms.Label AllEmployeesLbl;
        private System.Windows.Forms.Label AllProjectsLbl;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Button ShutDownBtn;
        private System.Windows.Forms.Button RemoveProjectBtn;
        private System.Windows.Forms.Button RemoveEmployeeBtn;
        private System.Windows.Forms.Button AddProjectBtn;
        private System.Windows.Forms.Button EmployeeDetailsBtn;
        private System.Windows.Forms.Button ProjectDetailsBtn;
        private System.Windows.Forms.Button EditEmployeeBtn;
        private System.Windows.Forms.Button EditProjectBtn;
    }
}