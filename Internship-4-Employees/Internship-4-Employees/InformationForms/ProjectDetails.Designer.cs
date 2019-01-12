namespace Internship_4_Employees
{
    partial class ProjectDetails
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
            this.NameLbl = new System.Windows.Forms.Label();
            this.AssignedToProjectRtb = new System.Windows.Forms.RichTextBox();
            this.StartLbl = new System.Windows.Forms.Label();
            this.FinishLbl = new System.Windows.Forms.Label();
            this.StateLbl = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(130, 35);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(205, 37);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Project name";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AssignedToProjectRtb
            // 
            this.AssignedToProjectRtb.Location = new System.Drawing.Point(31, 184);
            this.AssignedToProjectRtb.Name = "AssignedToProjectRtb";
            this.AssignedToProjectRtb.Size = new System.Drawing.Size(409, 301);
            this.AssignedToProjectRtb.TabIndex = 1;
            this.AssignedToProjectRtb.Text = "";
            // 
            // StartLbl
            // 
            this.StartLbl.AutoSize = true;
            this.StartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartLbl.Location = new System.Drawing.Point(143, 103);
            this.StartLbl.Name = "StartLbl";
            this.StartLbl.Size = new System.Drawing.Size(80, 20);
            this.StartLbl.TabIndex = 2;
            this.StartLbl.Text = "Start date";
            // 
            // FinishLbl
            // 
            this.FinishLbl.AutoSize = true;
            this.FinishLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishLbl.Location = new System.Drawing.Point(249, 103);
            this.FinishLbl.Name = "FinishLbl";
            this.FinishLbl.Size = new System.Drawing.Size(87, 20);
            this.FinishLbl.TabIndex = 3;
            this.FinishLbl.Text = "Finish date";
            // 
            // StateLbl
            // 
            this.StateLbl.AutoSize = true;
            this.StateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLbl.Location = new System.Drawing.Point(162, 141);
            this.StateLbl.Name = "StateLbl";
            this.StateLbl.Size = new System.Drawing.Size(133, 24);
            this.StateLbl.TabIndex = 4;
            this.StateLbl.Text = "State of project";
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(136, 501);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(199, 56);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 569);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.StateLbl);
            this.Controls.Add(this.FinishLbl);
            this.Controls.Add(this.StartLbl);
            this.Controls.Add(this.AssignedToProjectRtb);
            this.Controls.Add(this.NameLbl);
            this.Name = "ProjectDetails";
            this.Text = "ProjectDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.RichTextBox AssignedToProjectRtb;
        private System.Windows.Forms.Label StartLbl;
        private System.Windows.Forms.Label FinishLbl;
        private System.Windows.Forms.Label StateLbl;
        private System.Windows.Forms.Button ExitBtn;
    }
}