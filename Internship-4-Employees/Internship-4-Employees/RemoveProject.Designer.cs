namespace Internship_4_Employees
{
    partial class RemoveProject
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
            this.RemoveProjectBtn = new System.Windows.Forms.Button();
            this.ProjectDetailsBtn = new System.Windows.Forms.Button();
            this.AllProjectsLbx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(292, 258);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(139, 75);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // RemoveProjectBtn
            // 
            this.RemoveProjectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveProjectBtn.Location = new System.Drawing.Point(292, 14);
            this.RemoveProjectBtn.Name = "RemoveProjectBtn";
            this.RemoveProjectBtn.Size = new System.Drawing.Size(139, 73);
            this.RemoveProjectBtn.TabIndex = 1;
            this.RemoveProjectBtn.Text = "Remove";
            this.RemoveProjectBtn.UseVisualStyleBackColor = true;
            // 
            // ProjectDetailsBtn
            // 
            this.ProjectDetailsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDetailsBtn.Location = new System.Drawing.Point(263, 142);
            this.ProjectDetailsBtn.Name = "ProjectDetailsBtn";
            this.ProjectDetailsBtn.Size = new System.Drawing.Size(189, 66);
            this.ProjectDetailsBtn.TabIndex = 2;
            this.ProjectDetailsBtn.Text = "Project Details";
            this.ProjectDetailsBtn.UseVisualStyleBackColor = true;
            // 
            // AllProjectsLbx
            // 
            this.AllProjectsLbx.FormattingEnabled = true;
            this.AllProjectsLbx.Location = new System.Drawing.Point(12, 14);
            this.AllProjectsLbx.Name = "AllProjectsLbx";
            this.AllProjectsLbx.Size = new System.Drawing.Size(232, 342);
            this.AllProjectsLbx.TabIndex = 3;
            // 
            // RemoveProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 383);
            this.Controls.Add(this.AllProjectsLbx);
            this.Controls.Add(this.ProjectDetailsBtn);
            this.Controls.Add(this.RemoveProjectBtn);
            this.Controls.Add(this.ExitBtn);
            this.Name = "RemoveProject";
            this.Text = "RemoveProject";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button RemoveProjectBtn;
        private System.Windows.Forms.Button ProjectDetailsBtn;
        private System.Windows.Forms.ListBox AllProjectsLbx;
    }
}