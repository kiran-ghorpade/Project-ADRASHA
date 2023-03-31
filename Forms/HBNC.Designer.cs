namespace ADRASHA_Main.Forms
{
    partial class HBNC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HBNC));
            this.panelControl3 = new ADRASHA_Main.PanelControl();
            this.lblashaname = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.btnHealth = new System.Windows.Forms.Button();
            this.btnPersonalProfile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnFirstExamination = new System.Windows.Forms.Button();
            this.BtnAddVisit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Angle = 0F;
            this.panelControl3.BackColor = System.Drawing.Color.Transparent;
            this.panelControl3.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.panelControl3.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.panelControl3.Location = new System.Drawing.Point(12, 12);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Rounding = 0;
            this.panelControl3.Size = new System.Drawing.Size(150, 125);
            this.panelControl3.TabIndex = 0;
            // 
            // lblashaname
            // 
            this.lblashaname.AutoSize = true;
            this.lblashaname.BackColor = System.Drawing.Color.Transparent;
            this.lblashaname.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblashaname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblashaname.Location = new System.Drawing.Point(174, 44);
            this.lblashaname.Name = "lblashaname";
            this.lblashaname.Size = new System.Drawing.Size(357, 88);
            this.lblashaname.TabIndex = 0;
            this.lblashaname.Text = "HBNC Profile";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberName.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMemberName.Location = new System.Drawing.Point(959, 17);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(522, 88);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Member Full Name";
            // 
            // btnHealth
            // 
            this.btnHealth.BackColor = System.Drawing.Color.Transparent;
            this.btnHealth.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnHealth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHealth.Location = new System.Drawing.Point(951, 127);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(266, 56);
            this.btnHealth.TabIndex = 0;
            this.btnHealth.Text = "Health Profile";
            this.btnHealth.UseVisualStyleBackColor = false;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // btnPersonalProfile
            // 
            this.btnPersonalProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonalProfile.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnPersonalProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnPersonalProfile.Location = new System.Drawing.Point(1263, 127);
            this.btnPersonalProfile.Name = "btnPersonalProfile";
            this.btnPersonalProfile.Size = new System.Drawing.Size(266, 56);
            this.btnPersonalProfile.TabIndex = 0;
            this.btnPersonalProfile.Text = "Personal Profile";
            this.btnPersonalProfile.UseVisualStyleBackColor = false;
            this.btnPersonalProfile.Click += new System.EventHandler(this.btnPersonalProfile_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(949, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 1);
            this.panel2.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.panel2);
            this.kryptonPanel1.Controls.Add(this.btnPersonalProfile);
            this.kryptonPanel1.Controls.Add(this.btnFirstExamination);
            this.kryptonPanel1.Controls.Add(this.BtnAddVisit);
            this.kryptonPanel1.Controls.Add(this.btnHealth);
            this.kryptonPanel1.Controls.Add(this.lblMemberName);
            this.kryptonPanel1.Controls.Add(this.lblashaname);
            this.kryptonPanel1.Controls.Add(this.pictureBox2);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.panelControl3);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1562, 844);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.kryptonPanel1.StateCommon.ColorAngle = 45F;
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // btnFirstExamination
            // 
            this.btnFirstExamination.BackColor = System.Drawing.Color.Transparent;
            this.btnFirstExamination.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnFirstExamination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnFirstExamination.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirstExamination.Location = new System.Drawing.Point(534, 421);
            this.btnFirstExamination.Name = "btnFirstExamination";
            this.btnFirstExamination.Size = new System.Drawing.Size(266, 56);
            this.btnFirstExamination.TabIndex = 0;
            this.btnFirstExamination.Text = "Add First Examination";
            this.btnFirstExamination.UseVisualStyleBackColor = false;
            this.btnFirstExamination.Click += new System.EventHandler(this.btnFirstExamination_Click);
            // 
            // BtnAddVisit
            // 
            this.BtnAddVisit.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddVisit.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.BtnAddVisit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.BtnAddVisit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddVisit.Location = new System.Drawing.Point(534, 583);
            this.BtnAddVisit.Name = "BtnAddVisit";
            this.BtnAddVisit.Size = new System.Drawing.Size(266, 56);
            this.BtnAddVisit.TabIndex = 0;
            this.BtnAddVisit.Text = "Add Visit";
            this.BtnAddVisit.UseVisualStyleBackColor = false;
            this.BtnAddVisit.Click += new System.EventHandler(this.BtnAddVisit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ADRASHA_Main.Properties.Resources.male_avtar;
            this.pictureBox2.Location = new System.Drawing.Point(839, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // HBNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 845);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "HBNC";
            this.Text = "HBNC";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PanelControl panelControl3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblashaname;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Button btnHealth;
        private System.Windows.Forms.Button btnPersonalProfile;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Button BtnAddVisit;
        private System.Windows.Forms.Button btnFirstExamination;
    }
}