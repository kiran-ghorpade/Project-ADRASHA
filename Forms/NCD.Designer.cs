using ADRASHA_Main.Forms;

namespace ADRASHA_Main
{
    partial class NCD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NCD));
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblashaname = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelControl3 = new ADRASHA_Main.PanelControl();
            this.sss = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlScreening = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Diagnosis_Date = new System.Windows.Forms.DateTimePicker();
            this.Screening_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Treatement_Status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NCD_Name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddCBAC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sss)).BeginInit();
            this.sss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlScreening)).BeginInit();
            this.pnlScreening.SuspendLayout();
            this.SuspendLayout();
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
            // lblashaname
            // 
            this.lblashaname.AutoSize = true;
            this.lblashaname.BackColor = System.Drawing.Color.Transparent;
            this.lblashaname.Font = new System.Drawing.Font("Poppins", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblashaname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblashaname.Location = new System.Drawing.Point(174, 44);
            this.lblashaname.Name = "lblashaname";
            this.lblashaname.Size = new System.Drawing.Size(305, 88);
            this.lblashaname.TabIndex = 0;
            this.lblashaname.Text = "NCD FORM";
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
            // sss
            // 
            this.sss.Controls.Add(this.kryptonPanel1);
            this.sss.Controls.Add(this.pnlScreening);
            this.sss.Controls.Add(this.panel2);
            this.sss.Controls.Add(this.btnBack);
            this.sss.Controls.Add(this.btnAddCBAC);
            this.sss.Controls.Add(this.lblMemberName);
            this.sss.Controls.Add(this.lblashaname);
            this.sss.Controls.Add(this.pictureBox2);
            this.sss.Controls.Add(this.pictureBox1);
            this.sss.Controls.Add(this.panelControl3);
            this.sss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sss.Location = new System.Drawing.Point(0, 0);
            this.sss.Name = "sss";
            this.sss.Size = new System.Drawing.Size(1544, 844);
            this.sss.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.sss.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.sss.StateCommon.ColorAngle = 45F;
            this.sss.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.sss.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.label6);
            this.kryptonPanel1.Location = new System.Drawing.Point(968, 302);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(564, 530);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(90)))), ((int)(((byte)(183)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.kryptonPanel1.StateCommon.ColorAngle = 45F;
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 60);
            this.label6.TabIndex = 0;
            this.label6.Text = "SCREENING HISTORY";
            // 
            // pnlScreening
            // 
            this.pnlScreening.Controls.Add(this.Diagnosis_Date);
            this.pnlScreening.Controls.Add(this.Screening_Date);
            this.pnlScreening.Controls.Add(this.label4);
            this.pnlScreening.Controls.Add(this.btnNew);
            this.pnlScreening.Controls.Add(this.btnAdd);
            this.pnlScreening.Controls.Add(this.label2);
            this.pnlScreening.Controls.Add(this.Treatement_Status);
            this.pnlScreening.Controls.Add(this.label5);
            this.pnlScreening.Controls.Add(this.NCD_Name);
            this.pnlScreening.Controls.Add(this.label3);
            this.pnlScreening.Controls.Add(this.label1);
            this.pnlScreening.Location = new System.Drawing.Point(321, 302);
            this.pnlScreening.Name = "pnlScreening";
            this.pnlScreening.Size = new System.Drawing.Size(641, 530);
            this.pnlScreening.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(90)))), ((int)(((byte)(183)))));
            this.pnlScreening.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.pnlScreening.StateCommon.ColorAngle = 45F;
            this.pnlScreening.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.pnlScreening.TabIndex = 0;
            // 
            // Diagnosis_Date
            // 
            this.Diagnosis_Date.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.Diagnosis_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diagnosis_Date.Location = new System.Drawing.Point(284, 279);
            this.Diagnosis_Date.Name = "Diagnosis_Date";
            this.Diagnosis_Date.Size = new System.Drawing.Size(233, 32);
            this.Diagnosis_Date.TabIndex = 3;
            // 
            // Screening_Date
            // 
            this.Screening_Date.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.Screening_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Screening_Date.Location = new System.Drawing.Point(284, 114);
            this.Screening_Date.Name = "Screening_Date";
            this.Screening_Date.Size = new System.Drawing.Size(233, 32);
            this.Screening_Date.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(58, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date of Diagnosis -";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(152, 447);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(145, 56);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(447, 447);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 56);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(58, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date of Screening -";
            // 
            // Treatement_Status
            // 
            this.Treatement_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Treatement_Status.FormattingEnabled = true;
            this.Treatement_Status.Items.AddRange(new object[] {
            "--Select--",
            "Initiated ",
            "DisContinued"});
            this.Treatement_Status.Location = new System.Drawing.Point(284, 365);
            this.Treatement_Status.Name = "Treatement_Status";
            this.Treatement_Status.Size = new System.Drawing.Size(327, 37);
            this.Treatement_Status.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(58, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Treatement Status -";
            // 
            // NCD_Name
            // 
            this.NCD_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCD_Name.FormattingEnabled = true;
            this.NCD_Name.Items.AddRange(new object[] {
            "--Select--",
            "Hypertension",
            "Diabetes",
            "Oral Cancer",
            "Breast Cancer",
            "COPD (Respiratory Disorder)",
            "Other"});
            this.NCD_Name.Location = new System.Drawing.Point(284, 189);
            this.NCD_Name.Name = "NCD_Name";
            this.NCD_Name.Size = new System.Drawing.Size(327, 37);
            this.NCD_Name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(58, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "NCD -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCREENING";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(949, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 1);
            this.panel2.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnBack.Location = new System.Drawing.Point(1263, 127);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(266, 56);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddCBAC
            // 
            this.btnAddCBAC.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCBAC.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddCBAC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnAddCBAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCBAC.Location = new System.Drawing.Point(27, 515);
            this.btnAddCBAC.Name = "btnAddCBAC";
            this.btnAddCBAC.Size = new System.Drawing.Size(266, 56);
            this.btnAddCBAC.TabIndex = 0;
            this.btnAddCBAC.Text = "Add CBAC";
            this.btnAddCBAC.UseVisualStyleBackColor = false;
            this.btnAddCBAC.Click += new System.EventHandler(this.btnAddCBAC_Click);
            // 
            // NCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 844);
            this.Controls.Add(this.sss);
            this.Name = "NCD";
            this.Text = "NCD_FORM";
            this.Load += new System.EventHandler(this.NCD_FORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sss)).EndInit();
            this.sss.ResumeLayout(false);
            this.sss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlScreening)).EndInit();
            this.pnlScreening.ResumeLayout(false);
            this.pnlScreening.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblashaname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PanelControl panelControl3;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel sss;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddCBAC;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlScreening;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NCD_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Screening_Date;
        private System.Windows.Forms.DateTimePicker Diagnosis_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Treatement_Status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNew;
    }
}