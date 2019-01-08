namespace Internship_4_Employees
{
    partial class RemoveEmployee
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
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AllEmployeesLbx = new System.Windows.Forms.ListBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(12, 431);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(151, 40);
            this.RemoveBtn.TabIndex = 5;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 80);
            this.label1.TabIndex = 4;
            this.label1.Text = "Click on the person you wish to remove \r\n\r\n\r\n\r\n";
            // 
            // AllEmployeesLbx
            // 
            this.AllEmployeesLbx.FormattingEnabled = true;
            this.AllEmployeesLbx.Location = new System.Drawing.Point(12, 12);
            this.AllEmployeesLbx.Name = "AllEmployeesLbx";
            this.AllEmployeesLbx.Size = new System.Drawing.Size(336, 381);
            this.AllEmployeesLbx.TabIndex = 6;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(198, 431);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(150, 40);
            this.BackBtn.TabIndex = 12;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // RemoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 495);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.AllEmployeesLbx);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.label1);
            this.Name = "RemoveEmployee";
            this.Text = "Removingcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox AllEmployeesLbx;
        private System.Windows.Forms.Button BackBtn;
    }
}