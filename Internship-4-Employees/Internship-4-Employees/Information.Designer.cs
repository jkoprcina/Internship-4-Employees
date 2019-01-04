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
            this.AllEmployeesRtb = new System.Windows.Forms.RichTextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AllProjectsLbx = new System.Windows.Forms.ListBox();
            this.ProjectDetailsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AllEmployeesRtb
            // 
            this.AllEmployeesRtb.Location = new System.Drawing.Point(12, 12);
            this.AllEmployeesRtb.Name = "AllEmployeesRtb";
            this.AllEmployeesRtb.Size = new System.Drawing.Size(608, 486);
            this.AllEmployeesRtb.TabIndex = 0;
            this.AllEmployeesRtb.Text = "";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(653, 436);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(200, 62);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(650, 12);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(203, 64);
            this.EditBtn.TabIndex = 2;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(697, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of projects";
            // 
            // AllProjectsLbx
            // 
            this.AllProjectsLbx.FormattingEnabled = true;
            this.AllProjectsLbx.Location = new System.Drawing.Point(653, 127);
            this.AllProjectsLbx.Name = "AllProjectsLbx";
            this.AllProjectsLbx.Size = new System.Drawing.Size(200, 225);
            this.AllProjectsLbx.TabIndex = 4;
            // 
            // ProjectDetailsBtn
            // 
            this.ProjectDetailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDetailsBtn.Location = new System.Drawing.Point(653, 368);
            this.ProjectDetailsBtn.Name = "ProjectDetailsBtn";
            this.ProjectDetailsBtn.Size = new System.Drawing.Size(200, 62);
            this.ProjectDetailsBtn.TabIndex = 5;
            this.ProjectDetailsBtn.Text = "Project Details";
            this.ProjectDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 510);
            this.Controls.Add(this.ProjectDetailsBtn);
            this.Controls.Add(this.AllProjectsLbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.AllEmployeesRtb);
            this.Name = "Information";
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox AllEmployeesRtb;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox AllProjectsLbx;
        private System.Windows.Forms.Button ProjectDetailsBtn;
    }
}