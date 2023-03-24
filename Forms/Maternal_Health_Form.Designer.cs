namespace ADRASHA_Main.Forms
{
    partial class Maternal_Health_Form
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
            this.Iron_Tablet_Given_Date = new System.Windows.Forms.DateTimePicker();
            this.Visit_date = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TT_injection_status = new System.Windows.Forms.ComboBox();
            this.Iron_tablets_Status = new System.Windows.Forms.ComboBox();
            this.Weight = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Blood_pressure = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPersonalProfile = new System.Windows.Forms.Button();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.Month_Of_Pregnancy = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Iron_Tablet_Given_Date
            // 
            this.Iron_Tablet_Given_Date.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.Iron_Tablet_Given_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iron_Tablet_Given_Date.Location = new System.Drawing.Point(316, 535);
            this.Iron_Tablet_Given_Date.Name = "Iron_Tablet_Given_Date";
            this.Iron_Tablet_Given_Date.Size = new System.Drawing.Size(233, 32);
            this.Iron_Tablet_Given_Date.TabIndex = 7;
            // 
            // Visit_date
            // 
            this.Visit_date.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.Visit_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visit_date.Location = new System.Drawing.Point(313, 77);
            this.Visit_date.Name = "Visit_date";
            this.Visit_date.Size = new System.Drawing.Size(233, 32);
            this.Visit_date.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnSubmit.Location = new System.Drawing.Point(236, 635);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 46);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 44);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Of Visit *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(9, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Month Of Pregnancy *";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Month_Of_Pregnancy);
            this.panel1.Controls.Add(this.TT_injection_status);
            this.panel1.Controls.Add(this.Iron_tablets_Status);
            this.panel1.Controls.Add(this.Weight);
            this.panel1.Controls.Add(this.Blood_pressure);
            this.panel1.Controls.Add(this.Iron_Tablet_Given_Date);
            this.panel1.Controls.Add(this.Visit_date);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(27, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 720);
            this.panel1.TabIndex = 0;
            // 
            // TT_injection_status
            // 
            this.TT_injection_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TT_injection_status.FormattingEnabled = true;
            this.TT_injection_status.Items.AddRange(new object[] {
            "Yes",
            "No",
            "\t\t\t"});
            this.TT_injection_status.Location = new System.Drawing.Point(313, 390);
            this.TT_injection_status.Name = "TT_injection_status";
            this.TT_injection_status.Size = new System.Drawing.Size(231, 37);
            this.TT_injection_status.TabIndex = 5;
            // 
            // Iron_tablets_Status
            // 
            this.Iron_tablets_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iron_tablets_Status.FormattingEnabled = true;
            this.Iron_tablets_Status.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Iron_tablets_Status.Location = new System.Drawing.Point(316, 466);
            this.Iron_tablets_Status.Name = "Iron_tablets_Status";
            this.Iron_tablets_Status.Size = new System.Drawing.Size(231, 37);
            this.Iron_tablets_Status.TabIndex = 6;
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(313, 314);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(228, 38);
            this.Weight.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Weight.StateCommon.Border.Rounding = 5;
            this.Weight.StateCommon.Border.Width = 1;
            this.Weight.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.TabIndex = 4;
            // 
            // Blood_pressure
            // 
            this.Blood_pressure.Location = new System.Drawing.Point(316, 234);
            this.Blood_pressure.Name = "Blood_pressure";
            this.Blood_pressure.Size = new System.Drawing.Size(233, 38);
            this.Blood_pressure.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Blood_pressure.StateCommon.Border.Rounding = 5;
            this.Blood_pressure.StateCommon.Border.Width = 1;
            this.Blood_pressure.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blood_pressure.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(540, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(19, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Blood Pressure";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(3, 535);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 44);
            this.label10.TabIndex = 0;
            this.label10.Text = "Date of Given ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(6, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 44);
            this.label9.TabIndex = 0;
            this.label9.Text = "Iron Tablets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(6, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 44);
            this.label6.TabIndex = 0;
            this.label6.Text = "TT Injection";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(6, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 44);
            this.label5.TabIndex = 0;
            this.label5.Text = "Weight";
            // 
            // btnPersonalProfile
            // 
            this.btnPersonalProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonalProfile.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnPersonalProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnPersonalProfile.Location = new System.Drawing.Point(493, 8);
            this.btnPersonalProfile.Name = "btnPersonalProfile";
            this.btnPersonalProfile.Size = new System.Drawing.Size(180, 46);
            this.btnPersonalProfile.TabIndex = 9;
            this.btnPersonalProfile.Text = "Cancel";
            this.btnPersonalProfile.UseVisualStyleBackColor = false;
            this.btnPersonalProfile.Click += new System.EventHandler(this.btnPersonalProfile_Click);
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.BackColor = System.Drawing.Color.Transparent;
            this.lblMemberName.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMemberName.Location = new System.Drawing.Point(114, 3);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(354, 60);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Member Full Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ADRASHA_Main.Properties.Resources.male_avtar;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(111, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 1);
            this.panel2.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.panel1);
            this.kryptonPanel1.Controls.Add(this.panel2);
            this.kryptonPanel1.Controls.Add(this.btnPersonalProfile);
            this.kryptonPanel1.Controls.Add(this.lblMemberName);
            this.kryptonPanel1.Controls.Add(this.pictureBox2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(720, 844);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.kryptonPanel1.StateCommon.ColorAngle = 45F;
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // Month_Of_Pregnancy
            // 
            this.Month_Of_Pregnancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month_Of_Pregnancy.FormattingEnabled = true;
            this.Month_Of_Pregnancy.Items.AddRange(new object[] {
            "--Select--",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.Month_Of_Pregnancy.Location = new System.Drawing.Point(315, 160);
            this.Month_Of_Pregnancy.Name = "Month_Of_Pregnancy";
            this.Month_Of_Pregnancy.Size = new System.Drawing.Size(231, 37);
            this.Month_Of_Pregnancy.TabIndex = 5;
            // 
            // Maternal_Health_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 844);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Maternal_Health_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maternal_Health_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker Iron_Tablet_Given_Date;
        private System.Windows.Forms.DateTimePicker Visit_date;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPersonalProfile;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Blood_pressure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox TT_injection_status;
        private System.Windows.Forms.ComboBox Iron_tablets_Status;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Weight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Month_Of_Pregnancy;
    }
}