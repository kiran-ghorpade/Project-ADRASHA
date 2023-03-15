namespace ADRASHA_Main.Forms
{
    partial class MemberListView
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
            this.Age = new System.Windows.Forms.Label();
            this.Member_Id = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.Member_Name = new System.Windows.Forms.Label();
            this.Profile_Image = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_Image)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.BackColor = System.Drawing.Color.Transparent;
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.Age.Location = new System.Drawing.Point(367, 60);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(49, 20);
            this.Age.TabIndex = 0;
            this.Age.Text = "xxxxx";
            this.Age.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Member_Id
            // 
            this.Member_Id.AutoSize = true;
            this.Member_Id.BackColor = System.Drawing.Color.Transparent;
            this.Member_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Member_Id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.Member_Id.Location = new System.Drawing.Point(211, 60);
            this.Member_Id.Name = "Member_Id";
            this.Member_Id.Size = new System.Drawing.Size(49, 20);
            this.Member_Id.TabIndex = 0;
            this.Member_Id.Text = "xxxxx";
            this.Member_Id.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.Transparent;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.label35.Location = new System.Drawing.Point(313, 60);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(48, 20);
            this.label35.TabIndex = 0;
            this.label35.Text = "Age :";
            this.label35.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.label36.Location = new System.Drawing.Point(98, 60);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(107, 20);
            this.label36.TabIndex = 0;
            this.label36.Text = "Member ID : ";
            this.label36.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Member_Name
            // 
            this.Member_Name.AutoSize = true;
            this.Member_Name.BackColor = System.Drawing.Color.Transparent;
            this.Member_Name.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Member_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.Member_Name.Location = new System.Drawing.Point(91, 5);
            this.Member_Name.Name = "Member_Name";
            this.Member_Name.Size = new System.Drawing.Size(258, 44);
            this.Member_Name.TabIndex = 0;
            this.Member_Name.Text = "Member Full Name";
            this.Member_Name.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Profile_Image
            // 
            this.Profile_Image.Image = global::ADRASHA_Main.Properties.Resources.male_avtar;
            this.Profile_Image.Location = new System.Drawing.Point(9, 5);
            this.Profile_Image.Name = "Profile_Image";
            this.Profile_Image.Size = new System.Drawing.Size(76, 58);
            this.Profile_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile_Image.TabIndex = 28;
            this.Profile_Image.TabStop = false;
            this.Profile_Image.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Age);
            this.panel1.Controls.Add(this.Member_Id);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.Member_Name);
            this.panel1.Controls.Add(this.Profile_Image);
            this.panel1.Location = new System.Drawing.Point(13, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 99);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // MemberListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "MemberListView";
            this.Size = new System.Drawing.Size(549, 121);
            ((System.ComponentModel.ISupportInitialize)(this.Profile_Image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Member_Id;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label Member_Name;
        private System.Windows.Forms.PictureBox Profile_Image;
        private System.Windows.Forms.Panel panel1;
    }
}
