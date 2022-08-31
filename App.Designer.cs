
namespace Amazing_Charts_Sample_Application
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.panelSide = new System.Windows.Forms.Panel();
            this.btnDeleete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.contactsLabel = new System.Windows.Forms.Label();
            this.contactPictureBox = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.emptyLabel = new System.Windows.Forms.Label();
            this.panelLayoutContacts = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactPictureBox)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(180)))));
            this.panelSide.Controls.Add(this.btnDeleete);
            this.panelSide.Controls.Add(this.btnAdd);
            this.panelSide.Controls.Add(this.btnExport);
            this.panelSide.Controls.Add(this.btnImport);
            this.panelSide.Controls.Add(this.contactsLabel);
            this.panelSide.Controls.Add(this.contactPictureBox);
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(300, 530);
            this.panelSide.TabIndex = 0;
            this.panelSide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sidePanel_MouseDown_1);
            this.panelSide.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sidePanel_MouseMove_1);
            this.panelSide.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sidePanel_MouseUp_1);
            // 
            // btnDeleete
            // 
            this.btnDeleete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleete.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleete.ForeColor = System.Drawing.Color.White;
            this.btnDeleete.Location = new System.Drawing.Point(169, 376);
            this.btnDeleete.Name = "btnDeleete";
            this.btnDeleete.Size = new System.Drawing.Size(95, 40);
            this.btnDeleete.TabIndex = 5;
            this.btnDeleete.Text = "Delete";
            this.btnDeleete.UseVisualStyleBackColor = true;
            this.btnDeleete.Click += new System.EventHandler(this.deleeteButton_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(36, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.addButton_Click);
            // 
            // btnExport
            // 
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(169, 300);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(95, 40);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(36, 300);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(95, 40);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.importButton_Click);
            // 
            // contactsLabel
            // 
            this.contactsLabel.AutoSize = true;
            this.contactsLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactsLabel.ForeColor = System.Drawing.Color.White;
            this.contactsLabel.Location = new System.Drawing.Point(102, 220);
            this.contactsLabel.Name = "contactsLabel";
            this.contactsLabel.Size = new System.Drawing.Size(97, 30);
            this.contactsLabel.TabIndex = 1;
            this.contactsLabel.Text = "Contacts";
            // 
            // contactPictureBox
            // 
            this.contactPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("contactPictureBox.Image")));
            this.contactPictureBox.Location = new System.Drawing.Point(75, 40);
            this.contactPictureBox.Name = "contactPictureBox";
            this.contactPictureBox.Size = new System.Drawing.Size(150, 150);
            this.contactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.contactPictureBox.TabIndex = 0;
            this.contactPictureBox.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(180)))));
            this.btnClose.Location = new System.Drawing.Point(410, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.panelTop);
            this.mainPanel.Controls.Add(this.panelSide);
            this.mainPanel.Controls.Add(this.panelGeneral);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(750, 530);
            this.mainPanel.TabIndex = 2;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Location = new System.Drawing.Point(300, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(450, 40);
            this.panelTop.TabIndex = 3;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sidePanel_MouseDown_1);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sidePanel_MouseMove_1);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sidePanel_MouseUp_1);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(180)))));
            this.btnMinimize.Location = new System.Drawing.Point(364, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 38);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // panelGeneral
            // 
            this.panelGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGeneral.BackColor = System.Drawing.Color.White;
            this.panelGeneral.Controls.Add(this.emptyLabel);
            this.panelGeneral.Controls.Add(this.panelLayoutContacts);
            this.panelGeneral.Location = new System.Drawing.Point(300, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(450, 530);
            this.panelGeneral.TabIndex = 4;
            // 
            // emptyLabel
            // 
            this.emptyLabel.AutoSize = true;
            this.emptyLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.emptyLabel.Location = new System.Drawing.Point(15, 57);
            this.emptyLabel.Name = "emptyLabel";
            this.emptyLabel.Size = new System.Drawing.Size(156, 15);
            this.emptyLabel.TabIndex = 0;
            this.emptyLabel.Text = "0 Contacts have been added";
            this.emptyLabel.Visible = false;
            // 
            // panelLayoutContacts
            // 
            this.panelLayoutContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLayoutContacts.AutoScroll = true;
            this.panelLayoutContacts.Location = new System.Drawing.Point(15, 75);
            this.panelLayoutContacts.Name = "panelLayoutContacts";
            this.panelLayoutContacts.Size = new System.Drawing.Size(421, 419);
            this.panelLayoutContacts.TabIndex = 0;
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(750, 530);
            this.Name = "Contacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Contacts_Load);
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactPictureBox)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.PictureBox contactPictureBox;
        private System.Windows.Forms.Label contactsLabel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.FlowLayoutPanel panelLayoutContacts;
        public System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Button btnExport;
        public System.Windows.Forms.Button btnDeleete;
        public System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label emptyLabel;
    }
}

