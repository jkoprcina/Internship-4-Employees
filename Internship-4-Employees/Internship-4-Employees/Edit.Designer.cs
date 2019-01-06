namespace Internship_4_Employees
{
    partial class Edit
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
            this.label1 = new System.Windows.Forms.Label();
            this.EditProjectBtn = new System.Windows.Forms.Button();
            this.AllEmployeesLbx = new System.Windows.Forms.ListBox();
            this.AllProjectsLbx = new System.Windows.Forms.ListBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ListEmployeesLbl = new System.Windows.Forms.Label();
            this.ListProjectsLbl = new System.Windows.Forms.Label();
            this.EditEmployeeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click on the person or project you wish to edit";
            // 
            // EditProjectBtn
            // 
            this.EditProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditProjectBtn.Location = new System.Drawing.Point(149, 438);
            this.EditProjectBtn.Name = "EditProjectBtn";
            this.EditProjectBtn.Size = new System.Drawing.Size(151, 40);
            this.EditProjectBtn.TabIndex = 2;
            this.EditProjectBtn.Text = "Edit Project";
            this.EditProjectBtn.UseVisualStyleBackColor = true;
            this.EditProjectBtn.Click += new System.EventHandler(this.EditProjectBtn_Click);
            // 
            // AllEmployeesLbx
            // 
            this.AllEmployeesLbx.FormattingEnabled = true;
            this.AllEmployeesLbx.Location = new System.Drawing.Point(12, 77);
            this.AllEmployeesLbx.Name = "AllEmployeesLbx";
            this.AllEmployeesLbx.Size = new System.Drawing.Size(209, 303);
            this.AllEmployeesLbx.TabIndex = 3;
            // 
            // AllProjectsLbx
            // 
            this.AllProjectsLbx.FormattingEnabled = true;
            this.AllProjectsLbx.Location = new System.Drawing.Point(237, 77);
            this.AllProjectsLbx.Name = "AllProjectsLbx";
            this.AllProjectsLbx.Size = new System.Drawing.Size(209, 303);
            this.AllProjectsLbx.TabIndex = 4;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(306, 438);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(140, 40);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ListEmployeesLbl
            // 
            this.ListEmployeesLbl.AutoSize = true;
            this.ListEmployeesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListEmployeesLbl.Location = new System.Drawing.Point(43, 36);
            this.ListEmployeesLbl.Name = "ListEmployeesLbl";
            this.ListEmployeesLbl.Size = new System.Drawing.Size(151, 20);
            this.ListEmployeesLbl.TabIndex = 6;
            this.ListEmployeesLbl.Text = "List of all employees";
            // 
            // ListProjectsLbl
            // 
            this.ListProjectsLbl.AutoSize = true;
            this.ListProjectsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListProjectsLbl.Location = new System.Drawing.Point(273, 36);
            this.ListProjectsLbl.Name = "ListProjectsLbl";
            this.ListProjectsLbl.Size = new System.Drawing.Size(131, 20);
            this.ListProjectsLbl.TabIndex = 7;
            this.ListProjectsLbl.Text = "List of all projects";
            // 
            // EditEmployeeBtn
            // 
            this.EditEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmployeeBtn.Location = new System.Drawing.Point(12, 438);
            this.EditEmployeeBtn.Name = "EditEmployeeBtn";
            this.EditEmployeeBtn.Size = new System.Drawing.Size(131, 40);
            this.EditEmployeeBtn.TabIndex = 8;
            this.EditEmployeeBtn.Text = "Edit Employee";
            this.EditEmployeeBtn.UseVisualStyleBackColor = true;
            this.EditEmployeeBtn.Click += new System.EventHandler(this.EditEmployeeBtn_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 490);
            this.Controls.Add(this.EditEmployeeBtn);
            this.Controls.Add(this.ListProjectsLbl);
            this.Controls.Add(this.ListEmployeesLbl);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AllProjectsLbx);
            this.Controls.Add(this.AllEmployeesLbx);
            this.Controls.Add(this.EditProjectBtn);
            this.Controls.Add(this.label1);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditProjectBtn;
        private System.Windows.Forms.ListBox AllProjectsLbx;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.ListBox AllEmployeesLbx;
        private System.Windows.Forms.Label ListEmployeesLbl;
        private System.Windows.Forms.Label ListProjectsLbl;
        private System.Windows.Forms.Button EditEmployeeBtn;
    }
}