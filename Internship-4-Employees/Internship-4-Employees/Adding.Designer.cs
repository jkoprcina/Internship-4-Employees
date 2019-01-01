namespace Internship_4_Employees
{
    partial class Adding
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.lastnameLbl = new System.Windows.Forms.Label();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.LastnameTbx = new System.Windows.Forms.TextBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddBtn = new System.Windows.Forms.Button();
            this.oibLbl = new System.Windows.Forms.Label();
            this.OIBTxb = new System.Windows.Forms.TextBox();
            this.AllProjectsCbx = new System.Windows.Forms.CheckedListBox();
            this.OccupationCmb = new System.Windows.Forms.ComboBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(12, 19);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(55, 20);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name:";
            // 
            // lastnameLbl
            // 
            this.lastnameLbl.AutoSize = true;
            this.lastnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnameLbl.Location = new System.Drawing.Point(12, 60);
            this.lastnameLbl.Name = "lastnameLbl";
            this.lastnameLbl.Size = new System.Drawing.Size(84, 20);
            this.lastnameLbl.TabIndex = 1;
            this.lastnameLbl.Text = "Lastname:";
            // 
            // NameTbx
            // 
            this.NameTbx.Location = new System.Drawing.Point(149, 21);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(190, 20);
            this.NameTbx.TabIndex = 2;
            // 
            // LastnameTbx
            // 
            this.LastnameTbx.Location = new System.Drawing.Point(149, 62);
            this.LastnameTbx.Name = "LastnameTbx";
            this.LastnameTbx.Size = new System.Drawing.Size(190, 20);
            this.LastnameTbx.TabIndex = 3;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Location = new System.Drawing.Point(69, 152);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.DateTimePicker1.TabIndex = 4;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.Location = new System.Drawing.Point(16, 415);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(152, 86);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "Add Employee";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // oibLbl
            // 
            this.oibLbl.AutoSize = true;
            this.oibLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oibLbl.Location = new System.Drawing.Point(12, 102);
            this.oibLbl.Name = "oibLbl";
            this.oibLbl.Size = new System.Drawing.Size(41, 20);
            this.oibLbl.TabIndex = 7;
            this.oibLbl.Text = "OIB:";
            // 
            // OIBTxb
            // 
            this.OIBTxb.Location = new System.Drawing.Point(149, 102);
            this.OIBTxb.Name = "OIBTxb";
            this.OIBTxb.Size = new System.Drawing.Size(190, 20);
            this.OIBTxb.TabIndex = 8;
            // 
            // AllProjectsCbx
            // 
            this.AllProjectsCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllProjectsCbx.FormattingEnabled = true;
            this.AllProjectsCbx.Location = new System.Drawing.Point(69, 239);
            this.AllProjectsCbx.Name = "AllProjectsCbx";
            this.AllProjectsCbx.Size = new System.Drawing.Size(214, 156);
            this.AllProjectsCbx.TabIndex = 9;
            // 
            // OccupationCmb
            // 
            this.OccupationCmb.FormattingEnabled = true;
            this.OccupationCmb.Location = new System.Drawing.Point(69, 194);
            this.OccupationCmb.Name = "OccupationCmb";
            this.OccupationCmb.Size = new System.Drawing.Size(214, 21);
            this.OccupationCmb.TabIndex = 10;
            // 
            // BackBtn
            // 
            this.BackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.Location = new System.Drawing.Point(193, 415);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(146, 86);
            this.BackBtn.TabIndex = 11;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // Adding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 533);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.OccupationCmb);
            this.Controls.Add(this.AllProjectsCbx);
            this.Controls.Add(this.OIBTxb);
            this.Controls.Add(this.oibLbl);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DateTimePicker1);
            this.Controls.Add(this.LastnameTbx);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.lastnameLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "Adding";
            this.Text = "Adding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label lastnameLbl;
        private System.Windows.Forms.TextBox NameTbx;
        private System.Windows.Forms.TextBox LastnameTbx;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label oibLbl;
        private System.Windows.Forms.TextBox OIBTxb;
        private System.Windows.Forms.CheckedListBox AllProjectsCbx;
        private System.Windows.Forms.ComboBox OccupationCmb;
        private System.Windows.Forms.Button BackBtn;
    }
}