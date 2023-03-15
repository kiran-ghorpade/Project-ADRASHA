namespace ADRASHA_Main.Forms
{
    partial class FamilyListView
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
            this.Head_Name = new System.Windows.Forms.Label();
            this.Total_Members = new System.Windows.Forms.Label();
            this.Family_Id = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.Profile_Image = new System.Windows.Forms.PictureBox();
            this.DisplayPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_Image)).BeginInit();
            this.DisplayPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Head_Name
            // 
            this.Head_Name.AutoSize = true;
            this.Head_Name.BackColor = System.Drawing.Color.Transparent;
            this.Head_Name.Font = new System.Drawing.Font("Poppins", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Head_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.Head_Name.Location = new System.Drawing.Point(135, 8);
            this.Head_Name.Name = "Head_Name";
            this.Head_Name.Size = new System.Drawing.Size(527, 74);
            this.Head_Name.TabIndex = 0;
            this.Head_Name.Text = "Family Head Full Name";
            this.Head_Name.Click += new System.EventHandler(this.DisplayPanel_Click);
            // 
            // Total_Members
            // 
            this.Total_Members.AutoSize = true;
            this.Total_Members.BackColor = System.Drawing.Color.Transparent;
            this.Total_Members.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Members.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.Total_Members.Location = new System.Drawing.Point(670, 82);
            this.Total_Members.Name = "Total_Members";
            this.Total_Members.Size = new System.Drawing.Size(73, 29);
            this.Total_Members.TabIndex = 0;
            this.Total_Members.Text = "xxxxx";
            this.Total_Members.Click += new System.EventHandler(this.DisplayPanel_Click);
            // 
            // Family_Id
            // 
            this.Family_Id.AutoSize = true;
            this.Family_Id.BackColor = System.Drawing.Color.Transparent;
            this.Family_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Family_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.Family_Id.Location = new System.Drawing.Point(300, 84);
            this.Family_Id.Name = "Family_Id";
            this.Family_Id.Size = new System.Drawing.Size(73, 29);
            this.Family_Id.TabIndex = 0;
            this.Family_Id.Text = "xxxxx";
            this.Family_Id.Click += new System.EventHandler(this.DisplayPanel_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.label35.Location = new System.Drawing.Point(451, 82);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(196, 29);
            this.label35.TabIndex = 0;
            this.label35.Text = "Total Members :";
            this.label35.Click += new System.EventHandler(this.DisplayPanel_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.label36.Location = new System.Drawing.Point(153, 84);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(141, 29);
            this.label36.TabIndex = 0;
            this.label36.Text = "Family ID : ";
            this.label36.Click += new System.EventHandler(this.DisplayPanel_Click);
            // 
            // Profile_Image
            // 
            this.Profile_Image.Image = global::ADRASHA_Main.Properties.Resources.house;
            this.Profile_Image.Location = new System.Drawing.Point(5, 8);
            this.Profile_Image.Name = "Profile_Image";
            this.Profile_Image.Size = new System.Drawing.Size(124, 105);
            this.Profile_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile_Image.TabIndex = 0;
            this.Profile_Image.TabStop = false;
            this.Profile_Image.Click += new System.EventHandler(this.DisplayPanel_Click);
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DisplayPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DisplayPanel.Controls.Add(this.Total_Members);
            this.DisplayPanel.Controls.Add(this.Family_Id);
            this.DisplayPanel.Controls.Add(this.label35);
            this.DisplayPanel.Controls.Add(this.label36);
            this.DisplayPanel.Controls.Add(this.Head_Name);
            this.DisplayPanel.Controls.Add(this.Profile_Image);
            this.DisplayPanel.Location = new System.Drawing.Point(13, 10);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(875, 130);
            this.DisplayPanel.TabIndex = 0;
            this.DisplayPanel.Click += new System.EventHandler(this.DisplayPanel_Click);
            // 
            // FamilyListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.DisplayPanel);
            this.DoubleBuffered = true;
            this.Name = "FamilyListView";
            this.Size = new System.Drawing.Size(900, 150);
            ((System.ComponentModel.ISupportInitialize)(this.Profile_Image)).EndInit();
            this.DisplayPanel.ResumeLayout(false);
            this.DisplayPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Profile_Image;
        private System.Windows.Forms.Label Head_Name;
        private System.Windows.Forms.Label Total_Members;
        private System.Windows.Forms.Label Family_Id;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        public System.Windows.Forms.Panel DisplayPanel;
    }
}
