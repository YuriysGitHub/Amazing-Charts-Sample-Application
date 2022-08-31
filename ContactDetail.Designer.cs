namespace Amazing_Charts_Sample_Application
{
    partial class ContactDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dateofBLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.openTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(180)))));
            this.lblFirstName.Location = new System.Drawing.Point(20, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 25);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListContact_MouseClick_1);
            this.lblFirstName.MouseLeave += new System.EventHandler(this.ListContact_MouseLeave_1);
            this.lblFirstName.MouseHover += new System.EventHandler(this.ListContact_MouseHover_1);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(180)))));
            this.btnEdit.Location = new System.Drawing.Point(317, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.editButton_Click);
            this.btnEdit.MouseLeave += new System.EventHandler(this.ListContact_MouseLeave_1);
            this.btnEdit.MouseHover += new System.EventHandler(this.ListContact_MouseHover_1);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(180)))));
            this.lblLastName.Location = new System.Drawing.Point(165, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(103, 25);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListContact_MouseClick_1);
            this.lblLastName.MouseLeave += new System.EventHandler(this.ListContact_MouseLeave_1);
            this.lblLastName.MouseHover += new System.EventHandler(this.ListContact_MouseHover_1);
            // 
            // dateofBLabel
            // 
            this.dateofBLabel.AutoSize = true;
            this.dateofBLabel.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateofBLabel.ForeColor = System.Drawing.Color.Black;
            this.dateofBLabel.Location = new System.Drawing.Point(10, 35);
            this.dateofBLabel.Name = "dateofBLabel";
            this.dateofBLabel.Size = new System.Drawing.Size(114, 21);
            this.dateofBLabel.TabIndex = 18;
            this.dateofBLabel.Text = "Date of Birth:";
            this.dateofBLabel.MouseLeave += new System.EventHandler(this.ListContact_MouseLeave_1);
            this.dateofBLabel.MouseHover += new System.EventHandler(this.ListContact_MouseHover_1);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.phoneNumberLabel.Location = new System.Drawing.Point(10, 65);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(132, 21);
            this.phoneNumberLabel.TabIndex = 19;
            this.phoneNumberLabel.Text = "Phone Number:";
            this.phoneNumberLabel.MouseLeave += new System.EventHandler(this.ListContact_MouseLeave_1);
            this.phoneNumberLabel.MouseHover += new System.EventHandler(this.ListContact_MouseHover_1);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(156, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 21);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Date";
            this.lblDate.MouseLeave += new System.EventHandler(this.ListContact_MouseLeave_1);
            this.lblDate.MouseHover += new System.EventHandler(this.ListContact_MouseHover_1);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.ForeColor = System.Drawing.Color.Black;
            this.lblNumber.Location = new System.Drawing.Point(156, 65);
            this.lblNumber.MaximumSize = new System.Drawing.Size(132, 21);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(59, 21);
            this.lblNumber.TabIndex = 21;
            this.lblNumber.Text = "Phone";
            this.lblNumber.MouseLeave += new System.EventHandler(this.ListContact_MouseLeave_1);
            this.lblNumber.MouseHover += new System.EventHandler(this.ListContact_MouseHover_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(3, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(12, 11);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.MouseLeave += new System.EventHandler(this.ListContact_MouseLeave_1);
            this.checkBox1.MouseHover += new System.EventHandler(this.ListContact_MouseHover_1);
            // 
            // openTimer
            // 
            this.openTimer.Interval = 10;
            this.openTimer.Tick += new System.EventHandler(this.openTimer_Tick);
            // 
            // ListContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.dateofBLabel);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblFirstName);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(180)))));
            this.MaximumSize = new System.Drawing.Size(397, 100);
            this.MinimumSize = new System.Drawing.Size(397, 30);
            this.Name = "ListContact";
            this.Size = new System.Drawing.Size(397, 100);
            this.Load += new System.EventHandler(this.ListContact_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListContact_MouseClick_1);
            this.MouseLeave += new System.EventHandler(this.ListContact_MouseLeave_1);
            this.MouseHover += new System.EventHandler(this.ListContact_MouseHover_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label dateofBLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer openTimer;
    }
}
