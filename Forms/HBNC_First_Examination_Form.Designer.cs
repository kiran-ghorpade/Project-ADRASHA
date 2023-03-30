namespace ADRASHA_Main.Forms
{
    partial class HBNC_First_Examination_Form
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
            this.Pre_term_status = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Weight = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.baby_feed = new System.Windows.Forms.ComboBox();
            this.Mother_problem = new System.Windows.Forms.ComboBox();
            this.Birth_Time = new System.Windows.Forms.DateTimePicker();
            this.Birth_date = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.Visit_date = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPersonalProfile = new System.Windows.Forms.Button();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Pre_term_status
            // 
            this.Pre_term_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pre_term_status.FormattingEnabled = true;
            this.Pre_term_status.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.Pre_term_status.Location = new System.Drawing.Point(332, 272);
            this.Pre_term_status.Name = "Pre_term_status";
            this.Pre_term_status.Size = new System.Drawing.Size(231, 37);
            this.Pre_term_status.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.Weight);
            this.panel1.Controls.Add(this.baby_feed);
            this.panel1.Controls.Add(this.Mother_problem);
            this.panel1.Controls.Add(this.Pre_term_status);
            this.panel1.Controls.Add(this.Birth_Time);
            this.panel1.Controls.Add(this.Birth_date);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.Visit_date);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(27, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 715);
            this.panel1.TabIndex = 0;
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(332, 566);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(233, 38);
            this.Weight.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Weight.StateCommon.Border.Rounding = 5;
            this.Weight.StateCommon.Border.Width = 1;
            this.Weight.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.TabIndex = 7;
            // 
            // baby_feed
            // 
            this.baby_feed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baby_feed.FormattingEnabled = true;
            this.baby_feed.Items.AddRange(new object[] {
            "--Select--",
            "Forcefully",
            "Weakly",
            "Could not breastfeed but had to be fed with spoon",
            "Could neither breastfeed nor take milk given by spoon"});
            this.baby_feed.Location = new System.Drawing.Point(332, 488);
            this.baby_feed.Name = "baby_feed";
            this.baby_feed.Size = new System.Drawing.Size(231, 37);
            this.baby_feed.TabIndex = 6;
            // 
            // Mother_problem
            // 
            this.Mother_problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mother_problem.FormattingEnabled = true;
            this.Mother_problem.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.Mother_problem.Location = new System.Drawing.Point(332, 398);
            this.Mother_problem.Name = "Mother_problem";
            this.Mother_problem.Size = new System.Drawing.Size(231, 37);
            this.Mother_problem.TabIndex = 5;
            // 
            // Birth_Time
            // 
            this.Birth_Time.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.Birth_Time.CustomFormat = "hh:mm";
            this.Birth_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Birth_Time.Location = new System.Drawing.Point(332, 192);
            this.Birth_Time.Name = "Birth_Time";
            this.Birth_Time.ShowUpDown = true;
            this.Birth_Time.Size = new System.Drawing.Size(233, 32);
            this.Birth_Time.TabIndex = 3;
            // 
            // Birth_date
            // 
            this.Birth_date.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.Birth_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birth_date.Location = new System.Drawing.Point(332, 118);
            this.Birth_date.Name = "Birth_date";
            this.Birth_date.Size = new System.Drawing.Size(233, 32);
            this.Birth_date.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(9, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 44);
            this.label12.TabIndex = 0;
            this.label12.Text = "Birth Time*";
            // 
            // Visit_date
            // 
            this.Visit_date.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.Visit_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visit_date.Location = new System.Drawing.Point(332, 43);
            this.Visit_date.Name = "Visit_date";
            this.Visit_date.Size = new System.Drawing.Size(233, 32);
            this.Visit_date.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(9, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 44);
            this.label11.TabIndex = 0;
            this.label11.Text = "Birth Date *";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnSubmit.Location = new System.Drawing.Point(236, 646);
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
            this.label3.Location = new System.Drawing.Point(9, 41);
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
            this.label2.Location = new System.Drawing.Point(9, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 44);
            this.label2.TabIndex = 0;
            this.label2.Text = "Is Baby Pre-term ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(3, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 44);
            this.label4.TabIndex = 0;
            this.label4.Text = "Weight :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(8, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "How did baby take feed ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(9, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 44);
            this.label5.TabIndex = 0;
            this.label5.Text = "Does Mother Have any Problem ?";
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
            this.kryptonPanel1.Size = new System.Drawing.Size(726, 845);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.kryptonPanel1.StateCommon.ColorAngle = 45F;
            this.kryptonPanel1.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(111, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 1);
            this.panel2.TabIndex = 0;
            // 
            // btnPersonalProfile
            // 
            this.btnPersonalProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonalProfile.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnPersonalProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnPersonalProfile.Location = new System.Drawing.Point(493, 8);
            this.btnPersonalProfile.Name = "btnPersonalProfile";
            this.btnPersonalProfile.Size = new System.Drawing.Size(180, 46);
            this.btnPersonalProfile.TabIndex = 0;
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
            // HBNC_First_Examination_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 845);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "HBNC_First_Examination_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HBNC_First_Examination_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Pre_term_status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Visit_date;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPersonalProfile;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker Birth_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker Birth_Time;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Mother_problem;
        private System.Windows.Forms.ComboBox baby_feed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Weight;
    }
}