namespace Internship_4_Employees
{
    partial class Information
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
            this.EditBtn = new System.Windows.Forms.Button();
            this.AllProjectslbl = new System.Windows.Forms.Label();
            this.AllProjectsLbx = new System.Windows.Forms.ListBox();
            this.ProjectDetailsBtn = new System.Windows.Forms.Button();
            this.AllEmployeesLbl = new System.Windows.Forms.Label();
            this.EmployeeDetailsBtn = new System.Windows.Forms.Button();
            this.AllEmployeesLbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(474, 380);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(200, 75);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(474, 48);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(203, 75);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AllProjectslbl
            // 
            this.AllProjectslbl.AutoSize = true;
            this.AllProjectslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProjectslbl.Location = new System.Drawing.Point(301, 12);
            this.AllProjectslbl.Name = "AllProjectslbl";
            this.AllProjectslbl.Size = new System.Drawing.Size(105, 18);
            this.AllProjectslbl.TabIndex = 3;
            this.AllProjectslbl.Text = "List of projects";
            // 
            // AllProjectsLbx
            // 
            this.AllProjectsLbx.FormattingEnabled = true;
            this.AllProjectsLbx.Location = new System.Drawing.Point(253, 48);
            this.AllProjectsLbx.Name = "AllProjectsLbx";
            this.AllProjectsLbx.Size = new System.Drawing.Size(200, 407);
            this.AllProjectsLbx.TabIndex = 4;
            // 
            // ProjectDetailsBtn
            // 
            this.ProjectDetailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDetailsBtn.Location = new System.Drawing.Point(474, 270);
            this.ProjectDetailsBtn.Name = "ProjectDetailsBtn";
            this.ProjectDetailsBtn.Size = new System.Drawing.Size(203, 75);
            this.ProjectDetailsBtn.TabIndex = 5;
            this.ProjectDetailsBtn.Text = "Project Details";
            this.ProjectDetailsBtn.UseVisualStyleBackColor = true;
            this.ProjectDetailsBtn.Click += new System.EventHandler(this.ProjectDetailsBtn_Click);
            // 
            // AllEmployeesLbl
            // 
            this.AllEmployeesLbl.AutoSize = true;
            this.AllEmployeesLbl.Location = new System.Drawing.Point(70, 17);
            this.AllEmployeesLbl.Name = "AllEmployeesLbl";
            this.AllEmployeesLbl.Size = new System.Drawing.Size(89, 13);
            this.AllEmployeesLbl.TabIndex = 6;
            this.AllEmployeesLbl.Text = "List of Employees";
            // 
            // EmployeeDetailsBtn
            // 
            this.EmployeeDetailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeDetailsBtn.Location = new System.Drawing.Point(474, 159);
            this.EmployeeDetailsBtn.Name = "EmployeeDetailsBtn";
            this.EmployeeDetailsBtn.Size = new System.Drawing.Size(203, 76);
            this.EmployeeDetailsBtn.TabIndex = 7;
            this.EmployeeDetailsBtn.Text = "Employee Details";
            this.EmployeeDetailsBtn.UseVisualStyleBackColor = true;
            this.EmployeeDetailsBtn.Click += new System.EventHandler(this.EmployeeDetailsBtn_Click);
            // 
            // AllEmployeesLbx
            // 
            this.AllEmployeesLbx.FormattingEnabled = true;
            this.AllEmployeesLbx.Location = new System.Drawing.Point(12, 48);
            this.AllEmployeesLbx.Name = "AllEmployeesLbx";
            this.AllEmployeesLbx.Size = new System.Drawing.Size(223, 407);
            this.AllEmployeesLbx.TabIndex = 8;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 510);
            this.Controls.Add(this.AllEmployeesLbx);
            this.Controls.Add(this.EmployeeDetailsBtn);
            this.Controls.Add(this.AllEmployeesLbl);
            this.Controls.Add(this.ProjectDetailsBtn);
            this.Controls.Add(this.AllProjectsLbx);
            this.Controls.Add(this.AllProjectslbl);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.ExitBtn);
            this.Name = "Information";
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label AllProjectslbl;
        private System.Windows.Forms.ListBox AllProjectsLbx;
        private System.Windows.Forms.Button ProjectDetailsBtn;
        private System.Windows.Forms.Label AllEmployeesLbl;
        private System.Windows.Forms.Button EmployeeDetailsBtn;
        private System.Windows.Forms.ListBox AllEmployeesLbx;
    }
}