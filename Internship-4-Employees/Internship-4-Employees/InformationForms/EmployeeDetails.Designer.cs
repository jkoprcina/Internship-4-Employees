﻿namespace Internship_4_Employees
{
    partial class EmployeeDetails
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
            this.EmployeeDetailsRtb = new System.Windows.Forms.RichTextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.NumberOfHoursWorkingBtn = new System.Windows.Forms.Button();
            this.ExplanationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeDetailsRtb
            // 
            this.EmployeeDetailsRtb.Location = new System.Drawing.Point(12, 12);
            this.EmployeeDetailsRtb.Name = "EmployeeDetailsRtb";
            this.EmployeeDetailsRtb.Size = new System.Drawing.Size(378, 299);
            this.EmployeeDetailsRtb.TabIndex = 0;
            this.EmployeeDetailsRtb.Text = "";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(116, 378);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(139, 68);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // NumberOfHoursWorkingBtn
            // 
            this.NumberOfHoursWorkingBtn.Location = new System.Drawing.Point(12, 317);
            this.NumberOfHoursWorkingBtn.Name = "NumberOfHoursWorkingBtn";
            this.NumberOfHoursWorkingBtn.Size = new System.Drawing.Size(96, 42);
            this.NumberOfHoursWorkingBtn.TabIndex = 2;
            this.NumberOfHoursWorkingBtn.UseVisualStyleBackColor = true;
            // 
            // ExplanationLbl
            // 
            this.ExplanationLbl.AutoSize = true;
            this.ExplanationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExplanationLbl.Location = new System.Drawing.Point(114, 317);
            this.ExplanationLbl.Name = "ExplanationLbl";
            this.ExplanationLbl.Size = new System.Drawing.Size(284, 39);
            this.ExplanationLbl.TabIndex = 3;
            this.ExplanationLbl.Text = "*red colour -> works too many hours\r\n yellow colour -> is recommended person work" +
    "s more hours\r\n green colour -> works optimal number of hours\r\n";
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 458);
            this.Controls.Add(this.ExplanationLbl);
            this.Controls.Add(this.NumberOfHoursWorkingBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EmployeeDetailsRtb);
            this.Name = "EmployeeDetails";
            this.Text = "EmployeeDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox EmployeeDetailsRtb;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button NumberOfHoursWorkingBtn;
        private System.Windows.Forms.Label ExplanationLbl;
    }
}