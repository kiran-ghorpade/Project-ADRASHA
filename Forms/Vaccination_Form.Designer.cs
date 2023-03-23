namespace ADRASHA_Main.Forms
{
    partial class Vaccination_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vaccination_Form));
            this.btnPersonalProfile = new System.Windows.Forms.Button();
            this.btnFamily = new System.Windows.Forms.Button();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblashaname = new System.Windows.Forms.Label();
            this.pnlBack = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pnlDatePIcker = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btnAddVaccination = new System.Windows.Forms.Button();
            this.Vaccination_Place = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Vaccination_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlVaccineBack = new System.Windows.Forms.Panel();
            this.BCG_D1 = new System.Windows.Forms.Button();
            this.VaccinationPicture = new System.Windows.Forms.PictureBox();
            this.HepB_D1 = new System.Windows.Forms.Button();
            this.HepB_D2 = new System.Windows.Forms.Button();
            this.DTaP_D1 = new System.Windows.Forms.Button();
            this.DTaP_D2 = new System.Windows.Forms.Button();
            this.HepB_D3 = new System.Windows.Forms.Button();
            this.DTaP_D3 = new System.Windows.Forms.Button();
            this.DTaP_B1 = new System.Windows.Forms.Button();
            this.IPV_B1 = new System.Windows.Forms.Button();
            this.Hib_B1 = new System.Windows.Forms.Button();
            this.Tdap_B2 = new System.Windows.Forms.Button();
            this.IPV_B2 = new System.Windows.Forms.Button();
            this.IPV_D1 = new System.Windows.Forms.Button();
            this.Hib_D1 = new System.Windows.Forms.Button();
            this.IPV_D2 = new System.Windows.Forms.Button();
            this.Hib_D2 = new System.Windows.Forms.Button();
            this.PCV_D2 = new System.Windows.Forms.Button();
            this.MMR_D2 = new System.Windows.Forms.Button();
            this.VAR_D2 = new System.Windows.Forms.Button();
            this.PCV_D1 = new System.Windows.Forms.Button();
            this.IPV_D3 = new System.Windows.Forms.Button();
            this.Hib_D3 = new System.Windows.Forms.Button();
            this.PCV_B1 = new System.Windows.Forms.Button();
            this.MMR_D1 = new System.Windows.Forms.Button();
            this.VAR_D1 = new System.Windows.Forms.Button();
            this.HPV_D1 = new System.Windows.Forms.Button();
            this.HPV_D2 = new System.Windows.Forms.Button();
            this.btnPnlClose = new System.Windows.Forms.Button();
            this.panelControl3 = new ADRASHA_Main.PanelControl();
            this.main_panelcontrol = new ADRASHA_Main.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBack)).BeginInit();
            this.pnlBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatePIcker)).BeginInit();
            this.pnlDatePIcker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlVaccineBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VaccinationPicture)).BeginInit();
            this.SuspendLayout();
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
            this.btnPersonalProfile.Text = "Health Profile";
            this.btnPersonalProfile.UseVisualStyleBackColor = false;
            this.btnPersonalProfile.Click += new System.EventHandler(this.btnPersonalProfile_Click);
            // 
            // btnFamily
            // 
            this.btnFamily.BackColor = System.Drawing.Color.Transparent;
            this.btnFamily.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnFamily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnFamily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFamily.Location = new System.Drawing.Point(951, 127);
            this.btnFamily.Name = "btnFamily";
            this.btnFamily.Size = new System.Drawing.Size(266, 56);
            this.btnFamily.TabIndex = 0;
            this.btnFamily.Text = "Family Profile";
            this.btnFamily.UseVisualStyleBackColor = false;
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
            this.lblashaname.Size = new System.Drawing.Size(526, 88);
            this.lblashaname.TabIndex = 0;
            this.lblashaname.Text = "Vaccination Profile";
            // 
            // pnlBack
            // 
            this.pnlBack.Controls.Add(this.panel2);
            this.pnlBack.Controls.Add(this.btnPersonalProfile);
            this.pnlBack.Controls.Add(this.btnFamily);
            this.pnlBack.Controls.Add(this.lblMemberName);
            this.pnlBack.Controls.Add(this.lblashaname);
            this.pnlBack.Controls.Add(this.pictureBox2);
            this.pnlBack.Controls.Add(this.pictureBox1);
            this.pnlBack.Controls.Add(this.panelControl3);
            this.pnlBack.Controls.Add(this.pnlVaccineBack);
            this.pnlBack.Controls.Add(this.main_panelcontrol);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1544, 857);
            this.pnlBack.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.pnlBack.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(61)))), ((int)(((byte)(95)))));
            this.pnlBack.StateCommon.ColorAngle = 45F;
            this.pnlBack.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.pnlBack.TabIndex = 0;
            // 
            // pnlDatePIcker
            // 
            this.pnlDatePIcker.Controls.Add(this.btnPnlClose);
            this.pnlDatePIcker.Controls.Add(this.btnAddVaccination);
            this.pnlDatePIcker.Controls.Add(this.Vaccination_Place);
            this.pnlDatePIcker.Controls.Add(this.Vaccination_Date);
            this.pnlDatePIcker.Controls.Add(this.label1);
            this.pnlDatePIcker.Controls.Add(this.label19);
            this.pnlDatePIcker.Controls.Add(this.label21);
            this.pnlDatePIcker.Location = new System.Drawing.Point(502, 171);
            this.pnlDatePIcker.Name = "pnlDatePIcker";
            this.pnlDatePIcker.Size = new System.Drawing.Size(503, 333);
            this.pnlDatePIcker.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(90)))), ((int)(((byte)(183)))));
            this.pnlDatePIcker.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(64)))), ((int)(((byte)(139)))));
            this.pnlDatePIcker.StateCommon.ColorAngle = 45F;
            this.pnlDatePIcker.StateCommon.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.pnlDatePIcker.TabIndex = 0;
            // 
            // btnAddVaccination
            // 
            this.btnAddVaccination.BackColor = System.Drawing.Color.Transparent;
            this.btnAddVaccination.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnAddVaccination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnAddVaccination.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddVaccination.Location = new System.Drawing.Point(320, 264);
            this.btnAddVaccination.Name = "btnAddVaccination";
            this.btnAddVaccination.Size = new System.Drawing.Size(141, 45);
            this.btnAddVaccination.TabIndex = 3;
            this.btnAddVaccination.Text = "Add";
            this.btnAddVaccination.UseVisualStyleBackColor = false;
            this.btnAddVaccination.Click += new System.EventHandler(this.btnAddVaccination_Click);
            // 
            // Vaccination_Place
            // 
            this.Vaccination_Place.Location = new System.Drawing.Point(145, 183);
            this.Vaccination_Place.Name = "Vaccination_Place";
            this.Vaccination_Place.Size = new System.Drawing.Size(327, 38);
            this.Vaccination_Place.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Vaccination_Place.StateCommon.Border.Rounding = 5;
            this.Vaccination_Place.StateCommon.Border.Width = 1;
            this.Vaccination_Place.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vaccination_Place.TabIndex = 2;
            this.Vaccination_Place.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Vaccination_Place_KeyPress);
            // 
            // Vaccination_Date
            // 
            this.Vaccination_Date.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.Vaccination_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vaccination_Date.Location = new System.Drawing.Point(145, 89);
            this.Vaccination_Date.Name = "Vaccination_Date";
            this.Vaccination_Date.Size = new System.Drawing.Size(233, 32);
            this.Vaccination_Date.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(18, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Place :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.MintCream;
            this.label19.Location = new System.Drawing.Point(18, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 31);
            this.label19.TabIndex = 0;
            this.label19.Text = "Date : ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Aladin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Cyan;
            this.label21.Location = new System.Drawing.Point(17, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(222, 42);
            this.label21.TabIndex = 0;
            this.label21.Text = "Vaccination Info -";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(949, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 1);
            this.panel2.TabIndex = 0;
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
            // pnlVaccineBack
            // 
            this.pnlVaccineBack.BackColor = System.Drawing.Color.Transparent;
            this.pnlVaccineBack.Controls.Add(this.pnlDatePIcker);
            this.pnlVaccineBack.Controls.Add(this.HepB_D3);
            this.pnlVaccineBack.Controls.Add(this.IPV_B2);
            this.pnlVaccineBack.Controls.Add(this.Tdap_B2);
            this.pnlVaccineBack.Controls.Add(this.PCV_B1);
            this.pnlVaccineBack.Controls.Add(this.Hib_B1);
            this.pnlVaccineBack.Controls.Add(this.IPV_B1);
            this.pnlVaccineBack.Controls.Add(this.DTaP_B1);
            this.pnlVaccineBack.Controls.Add(this.Hib_D3);
            this.pnlVaccineBack.Controls.Add(this.IPV_D3);
            this.pnlVaccineBack.Controls.Add(this.DTaP_D3);
            this.pnlVaccineBack.Controls.Add(this.HPV_D2);
            this.pnlVaccineBack.Controls.Add(this.VAR_D2);
            this.pnlVaccineBack.Controls.Add(this.MMR_D2);
            this.pnlVaccineBack.Controls.Add(this.PCV_D2);
            this.pnlVaccineBack.Controls.Add(this.Hib_D2);
            this.pnlVaccineBack.Controls.Add(this.IPV_D2);
            this.pnlVaccineBack.Controls.Add(this.DTaP_D2);
            this.pnlVaccineBack.Controls.Add(this.Hib_D1);
            this.pnlVaccineBack.Controls.Add(this.HPV_D1);
            this.pnlVaccineBack.Controls.Add(this.VAR_D1);
            this.pnlVaccineBack.Controls.Add(this.MMR_D1);
            this.pnlVaccineBack.Controls.Add(this.PCV_D1);
            this.pnlVaccineBack.Controls.Add(this.IPV_D1);
            this.pnlVaccineBack.Controls.Add(this.DTaP_D1);
            this.pnlVaccineBack.Controls.Add(this.HepB_D2);
            this.pnlVaccineBack.Controls.Add(this.HepB_D1);
            this.pnlVaccineBack.Controls.Add(this.BCG_D1);
            this.pnlVaccineBack.Controls.Add(this.VaccinationPicture);
            this.pnlVaccineBack.Location = new System.Drawing.Point(27, 230);
            this.pnlVaccineBack.Name = "pnlVaccineBack";
            this.pnlVaccineBack.Size = new System.Drawing.Size(1485, 591);
            this.pnlVaccineBack.TabIndex = 0;
            // 
            // BCG_D1
            // 
            this.BCG_D1.BackColor = System.Drawing.Color.Red;
            this.BCG_D1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.BCG_D1.ForeColor = System.Drawing.Color.Transparent;
            this.BCG_D1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCG_D1.Location = new System.Drawing.Point(266, 54);
            this.BCG_D1.Name = "BCG_D1";
            this.BCG_D1.Size = new System.Drawing.Size(92, 42);
            this.BCG_D1.TabIndex = 0;
            this.BCG_D1.Text = "Dose 1";
            this.BCG_D1.UseVisualStyleBackColor = false;
            this.BCG_D1.Click += new System.EventHandler(this.btnBCG_D1_Click);
            // 
            // VaccinationPicture
            // 
            this.VaccinationPicture.BackColor = System.Drawing.Color.Transparent;
            this.VaccinationPicture.Image = ((System.Drawing.Image)(resources.GetObject("VaccinationPicture.Image")));
            this.VaccinationPicture.Location = new System.Drawing.Point(3, 3);
            this.VaccinationPicture.Name = "VaccinationPicture";
            this.VaccinationPicture.Size = new System.Drawing.Size(1472, 591);
            this.VaccinationPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.VaccinationPicture.TabIndex = 6;
            this.VaccinationPicture.TabStop = false;
            // 
            // HepB_D1
            // 
            this.HepB_D1.BackColor = System.Drawing.Color.Red;
            this.HepB_D1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.HepB_D1.ForeColor = System.Drawing.Color.Transparent;
            this.HepB_D1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HepB_D1.Location = new System.Drawing.Point(266, 93);
            this.HepB_D1.Name = "HepB_D1";
            this.HepB_D1.Size = new System.Drawing.Size(92, 46);
            this.HepB_D1.TabIndex = 0;
            this.HepB_D1.Text = "Dose 1";
            this.HepB_D1.UseVisualStyleBackColor = false;
            this.HepB_D1.Click += new System.EventHandler(this.HepB_D1_Click);
            // 
            // HepB_D2
            // 
            this.HepB_D2.BackColor = System.Drawing.Color.Red;
            this.HepB_D2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.HepB_D2.ForeColor = System.Drawing.Color.Transparent;
            this.HepB_D2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HepB_D2.Location = new System.Drawing.Point(357, 93);
            this.HepB_D2.Name = "HepB_D2";
            this.HepB_D2.Size = new System.Drawing.Size(92, 46);
            this.HepB_D2.TabIndex = 0;
            this.HepB_D2.Text = "Dose 2";
            this.HepB_D2.UseVisualStyleBackColor = false;
            this.HepB_D2.Click += new System.EventHandler(this.HepB_D2_Click);
            // 
            // DTaP_D1
            // 
            this.DTaP_D1.BackColor = System.Drawing.Color.Red;
            this.DTaP_D1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.DTaP_D1.ForeColor = System.Drawing.Color.Transparent;
            this.DTaP_D1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DTaP_D1.Location = new System.Drawing.Point(357, 139);
            this.DTaP_D1.Name = "DTaP_D1";
            this.DTaP_D1.Size = new System.Drawing.Size(92, 46);
            this.DTaP_D1.TabIndex = 0;
            this.DTaP_D1.Text = "Dose 1";
            this.DTaP_D1.UseVisualStyleBackColor = false;
            this.DTaP_D1.Click += new System.EventHandler(this.DTaP_D1_Click);
            // 
            // DTaP_D2
            // 
            this.DTaP_D2.BackColor = System.Drawing.Color.Red;
            this.DTaP_D2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.DTaP_D2.ForeColor = System.Drawing.Color.Transparent;
            this.DTaP_D2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DTaP_D2.Location = new System.Drawing.Point(453, 139);
            this.DTaP_D2.Name = "DTaP_D2";
            this.DTaP_D2.Size = new System.Drawing.Size(92, 46);
            this.DTaP_D2.TabIndex = 0;
            this.DTaP_D2.Text = "Dose 2";
            this.DTaP_D2.UseVisualStyleBackColor = false;
            this.DTaP_D2.Click += new System.EventHandler(this.DTaP_D2_Click);
            // 
            // HepB_D3
            // 
            this.HepB_D3.BackColor = System.Drawing.Color.Red;
            this.HepB_D3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.HepB_D3.ForeColor = System.Drawing.Color.Transparent;
            this.HepB_D3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HepB_D3.Location = new System.Drawing.Point(541, 93);
            this.HepB_D3.Name = "HepB_D3";
            this.HepB_D3.Size = new System.Drawing.Size(92, 46);
            this.HepB_D3.TabIndex = 0;
            this.HepB_D3.Text = "Dose 3";
            this.HepB_D3.UseVisualStyleBackColor = false;
            this.HepB_D3.Click += new System.EventHandler(this.HepB_D3_Click);
            // 
            // DTaP_D3
            // 
            this.DTaP_D3.BackColor = System.Drawing.Color.Red;
            this.DTaP_D3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.DTaP_D3.ForeColor = System.Drawing.Color.Transparent;
            this.DTaP_D3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DTaP_D3.Location = new System.Drawing.Point(544, 139);
            this.DTaP_D3.Name = "DTaP_D3";
            this.DTaP_D3.Size = new System.Drawing.Size(92, 46);
            this.DTaP_D3.TabIndex = 0;
            this.DTaP_D3.Text = "Dose 3";
            this.DTaP_D3.UseVisualStyleBackColor = false;
            this.DTaP_D3.Click += new System.EventHandler(this.DTaP_D3_Click);
            // 
            // DTaP_B1
            // 
            this.DTaP_B1.BackColor = System.Drawing.Color.Red;
            this.DTaP_B1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.DTaP_B1.ForeColor = System.Drawing.Color.Transparent;
            this.DTaP_B1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DTaP_B1.Location = new System.Drawing.Point(822, 139);
            this.DTaP_B1.Name = "DTaP_B1";
            this.DTaP_B1.Size = new System.Drawing.Size(92, 46);
            this.DTaP_B1.TabIndex = 0;
            this.DTaP_B1.Text = "Booster ";
            this.DTaP_B1.UseVisualStyleBackColor = false;
            this.DTaP_B1.Click += new System.EventHandler(this.DTaP_B1_Click);
            // 
            // IPV_B1
            // 
            this.IPV_B1.BackColor = System.Drawing.Color.Red;
            this.IPV_B1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.IPV_B1.ForeColor = System.Drawing.Color.Transparent;
            this.IPV_B1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IPV_B1.Location = new System.Drawing.Point(821, 230);
            this.IPV_B1.Name = "IPV_B1";
            this.IPV_B1.Size = new System.Drawing.Size(92, 43);
            this.IPV_B1.TabIndex = 0;
            this.IPV_B1.Text = "Booster 1";
            this.IPV_B1.UseVisualStyleBackColor = false;
            this.IPV_B1.Click += new System.EventHandler(this.IPV_B1_Click);
            // 
            // Hib_B1
            // 
            this.Hib_B1.BackColor = System.Drawing.Color.Red;
            this.Hib_B1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Hib_B1.ForeColor = System.Drawing.Color.Transparent;
            this.Hib_B1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hib_B1.Location = new System.Drawing.Point(821, 275);
            this.Hib_B1.Name = "Hib_B1";
            this.Hib_B1.Size = new System.Drawing.Size(92, 43);
            this.Hib_B1.TabIndex = 0;
            this.Hib_B1.Text = "Booster 1";
            this.Hib_B1.UseVisualStyleBackColor = false;
            this.Hib_B1.Click += new System.EventHandler(this.Hib_B1_Click);
            // 
            // Tdap_B2
            // 
            this.Tdap_B2.BackColor = System.Drawing.Color.Red;
            this.Tdap_B2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Tdap_B2.ForeColor = System.Drawing.Color.Transparent;
            this.Tdap_B2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tdap_B2.Location = new System.Drawing.Point(1098, 186);
            this.Tdap_B2.Name = "Tdap_B2";
            this.Tdap_B2.Size = new System.Drawing.Size(92, 43);
            this.Tdap_B2.TabIndex = 0;
            this.Tdap_B2.Text = "Booster 2";
            this.Tdap_B2.UseVisualStyleBackColor = false;
            this.Tdap_B2.Click += new System.EventHandler(this.Tdap_B2_Click);
            // 
            // IPV_B2
            // 
            this.IPV_B2.BackColor = System.Drawing.Color.Red;
            this.IPV_B2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.IPV_B2.ForeColor = System.Drawing.Color.Transparent;
            this.IPV_B2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IPV_B2.Location = new System.Drawing.Point(1098, 230);
            this.IPV_B2.Name = "IPV_B2";
            this.IPV_B2.Size = new System.Drawing.Size(92, 43);
            this.IPV_B2.TabIndex = 0;
            this.IPV_B2.Text = "Booster 2";
            this.IPV_B2.UseVisualStyleBackColor = false;
            this.IPV_B2.Click += new System.EventHandler(this.Hib_B2_Click);
            // 
            // IPV_D1
            // 
            this.IPV_D1.BackColor = System.Drawing.Color.Red;
            this.IPV_D1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.IPV_D1.ForeColor = System.Drawing.Color.Transparent;
            this.IPV_D1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IPV_D1.Location = new System.Drawing.Point(357, 227);
            this.IPV_D1.Name = "IPV_D1";
            this.IPV_D1.Size = new System.Drawing.Size(92, 46);
            this.IPV_D1.TabIndex = 0;
            this.IPV_D1.Text = "Dose 1";
            this.IPV_D1.UseVisualStyleBackColor = false;
            this.IPV_D1.Click += new System.EventHandler(this.IPV_D1_Click);
            // 
            // Hib_D1
            // 
            this.Hib_D1.BackColor = System.Drawing.Color.Red;
            this.Hib_D1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Hib_D1.ForeColor = System.Drawing.Color.Transparent;
            this.Hib_D1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hib_D1.Location = new System.Drawing.Point(357, 273);
            this.Hib_D1.Name = "Hib_D1";
            this.Hib_D1.Size = new System.Drawing.Size(92, 46);
            this.Hib_D1.TabIndex = 0;
            this.Hib_D1.Text = "Dose 1";
            this.Hib_D1.UseVisualStyleBackColor = false;
            this.Hib_D1.Click += new System.EventHandler(this.Hib_D1_Click);
            // 
            // IPV_D2
            // 
            this.IPV_D2.BackColor = System.Drawing.Color.Red;
            this.IPV_D2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.IPV_D2.ForeColor = System.Drawing.Color.Transparent;
            this.IPV_D2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IPV_D2.Location = new System.Drawing.Point(453, 227);
            this.IPV_D2.Name = "IPV_D2";
            this.IPV_D2.Size = new System.Drawing.Size(92, 46);
            this.IPV_D2.TabIndex = 0;
            this.IPV_D2.Text = "Dose 2";
            this.IPV_D2.UseVisualStyleBackColor = false;
            this.IPV_D2.Click += new System.EventHandler(this.IPV_D2_Click);
            // 
            // Hib_D2
            // 
            this.Hib_D2.BackColor = System.Drawing.Color.Red;
            this.Hib_D2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Hib_D2.ForeColor = System.Drawing.Color.Transparent;
            this.Hib_D2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hib_D2.Location = new System.Drawing.Point(453, 272);
            this.Hib_D2.Name = "Hib_D2";
            this.Hib_D2.Size = new System.Drawing.Size(92, 46);
            this.Hib_D2.TabIndex = 0;
            this.Hib_D2.Text = "Dose 2";
            this.Hib_D2.UseVisualStyleBackColor = false;
            this.Hib_D2.Click += new System.EventHandler(this.Hib_D2_Click);
            // 
            // PCV_D2
            // 
            this.PCV_D2.BackColor = System.Drawing.Color.Red;
            this.PCV_D2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.PCV_D2.ForeColor = System.Drawing.Color.Transparent;
            this.PCV_D2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PCV_D2.Location = new System.Drawing.Point(541, 316);
            this.PCV_D2.Name = "PCV_D2";
            this.PCV_D2.Size = new System.Drawing.Size(92, 46);
            this.PCV_D2.TabIndex = 0;
            this.PCV_D2.Text = "Dose 2";
            this.PCV_D2.UseVisualStyleBackColor = false;
            this.PCV_D2.Click += new System.EventHandler(this.PCV_D2_Click);
            // 
            // MMR_D2
            // 
            this.MMR_D2.BackColor = System.Drawing.Color.Red;
            this.MMR_D2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.MMR_D2.ForeColor = System.Drawing.Color.Transparent;
            this.MMR_D2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MMR_D2.Location = new System.Drawing.Point(729, 406);
            this.MMR_D2.Name = "MMR_D2";
            this.MMR_D2.Size = new System.Drawing.Size(92, 46);
            this.MMR_D2.TabIndex = 0;
            this.MMR_D2.Text = "Dose 2";
            this.MMR_D2.UseVisualStyleBackColor = false;
            this.MMR_D2.Click += new System.EventHandler(this.MMR_D2_Click);
            // 
            // VAR_D2
            // 
            this.VAR_D2.BackColor = System.Drawing.Color.Red;
            this.VAR_D2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.VAR_D2.ForeColor = System.Drawing.Color.Transparent;
            this.VAR_D2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VAR_D2.Location = new System.Drawing.Point(729, 449);
            this.VAR_D2.Name = "VAR_D2";
            this.VAR_D2.Size = new System.Drawing.Size(92, 46);
            this.VAR_D2.TabIndex = 0;
            this.VAR_D2.Text = "Dose 2";
            this.VAR_D2.UseVisualStyleBackColor = false;
            this.VAR_D2.Click += new System.EventHandler(this.VAR_D2_Click);
            // 
            // PCV_D1
            // 
            this.PCV_D1.BackColor = System.Drawing.Color.Red;
            this.PCV_D1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.PCV_D1.ForeColor = System.Drawing.Color.Transparent;
            this.PCV_D1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PCV_D1.Location = new System.Drawing.Point(451, 316);
            this.PCV_D1.Name = "PCV_D1";
            this.PCV_D1.Size = new System.Drawing.Size(92, 46);
            this.PCV_D1.TabIndex = 0;
            this.PCV_D1.Text = "Dose 1";
            this.PCV_D1.UseVisualStyleBackColor = false;
            this.PCV_D1.Click += new System.EventHandler(this.PCV_D1_Click);
            // 
            // IPV_D3
            // 
            this.IPV_D3.BackColor = System.Drawing.Color.Red;
            this.IPV_D3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.IPV_D3.ForeColor = System.Drawing.Color.Transparent;
            this.IPV_D3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IPV_D3.Location = new System.Drawing.Point(544, 228);
            this.IPV_D3.Name = "IPV_D3";
            this.IPV_D3.Size = new System.Drawing.Size(92, 46);
            this.IPV_D3.TabIndex = 0;
            this.IPV_D3.Text = "Dose 3";
            this.IPV_D3.UseVisualStyleBackColor = false;
            this.IPV_D3.Click += new System.EventHandler(this.IPV_D3_Click);
            // 
            // Hib_D3
            // 
            this.Hib_D3.BackColor = System.Drawing.Color.Red;
            this.Hib_D3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.Hib_D3.ForeColor = System.Drawing.Color.Transparent;
            this.Hib_D3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hib_D3.Location = new System.Drawing.Point(544, 272);
            this.Hib_D3.Name = "Hib_D3";
            this.Hib_D3.Size = new System.Drawing.Size(92, 46);
            this.Hib_D3.TabIndex = 0;
            this.Hib_D3.Text = "Dose 3";
            this.Hib_D3.UseVisualStyleBackColor = false;
            this.Hib_D3.Click += new System.EventHandler(this.Hib_D3_Click);
            // 
            // PCV_B1
            // 
            this.PCV_B1.BackColor = System.Drawing.Color.Red;
            this.PCV_B1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.PCV_B1.ForeColor = System.Drawing.Color.Transparent;
            this.PCV_B1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PCV_B1.Location = new System.Drawing.Point(639, 319);
            this.PCV_B1.Name = "PCV_B1";
            this.PCV_B1.Size = new System.Drawing.Size(92, 43);
            this.PCV_B1.TabIndex = 0;
            this.PCV_B1.Text = "Booster 1";
            this.PCV_B1.UseVisualStyleBackColor = false;
            this.PCV_B1.Click += new System.EventHandler(this.PCV_B1_Click);
            // 
            // MMR_D1
            // 
            this.MMR_D1.BackColor = System.Drawing.Color.Red;
            this.MMR_D1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.MMR_D1.ForeColor = System.Drawing.Color.Transparent;
            this.MMR_D1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MMR_D1.Location = new System.Drawing.Point(637, 406);
            this.MMR_D1.Name = "MMR_D1";
            this.MMR_D1.Size = new System.Drawing.Size(92, 46);
            this.MMR_D1.TabIndex = 0;
            this.MMR_D1.Text = "Dose 1";
            this.MMR_D1.UseVisualStyleBackColor = false;
            this.MMR_D1.Click += new System.EventHandler(this.MMR_D1_Click);
            // 
            // VAR_D1
            // 
            this.VAR_D1.BackColor = System.Drawing.Color.Red;
            this.VAR_D1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.VAR_D1.ForeColor = System.Drawing.Color.Transparent;
            this.VAR_D1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.VAR_D1.Location = new System.Drawing.Point(637, 449);
            this.VAR_D1.Name = "VAR_D1";
            this.VAR_D1.Size = new System.Drawing.Size(92, 46);
            this.VAR_D1.TabIndex = 0;
            this.VAR_D1.Text = "Dose 1";
            this.VAR_D1.UseVisualStyleBackColor = false;
            this.VAR_D1.Click += new System.EventHandler(this.VAR_D1_Click);
            // 
            // HPV_D1
            // 
            this.HPV_D1.BackColor = System.Drawing.Color.Red;
            this.HPV_D1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.HPV_D1.ForeColor = System.Drawing.Color.Transparent;
            this.HPV_D1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HPV_D1.Location = new System.Drawing.Point(1190, 494);
            this.HPV_D1.Name = "HPV_D1";
            this.HPV_D1.Size = new System.Drawing.Size(92, 46);
            this.HPV_D1.TabIndex = 0;
            this.HPV_D1.Text = "Dose 1";
            this.HPV_D1.UseVisualStyleBackColor = false;
            this.HPV_D1.Click += new System.EventHandler(this.HPV_D1_Click);
            // 
            // HPV_D2
            // 
            this.HPV_D2.BackColor = System.Drawing.Color.Red;
            this.HPV_D2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.HPV_D2.ForeColor = System.Drawing.Color.Transparent;
            this.HPV_D2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HPV_D2.Location = new System.Drawing.Point(1285, 494);
            this.HPV_D2.Name = "HPV_D2";
            this.HPV_D2.Size = new System.Drawing.Size(92, 46);
            this.HPV_D2.TabIndex = 0;
            this.HPV_D2.Text = "Dose 2";
            this.HPV_D2.UseVisualStyleBackColor = false;
            this.HPV_D2.Click += new System.EventHandler(this.HPV_D2_Click);
            // 
            // btnPnlClose
            // 
            this.btnPnlClose.BackColor = System.Drawing.Color.Transparent;
            this.btnPnlClose.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.btnPnlClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(100)))));
            this.btnPnlClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPnlClose.Location = new System.Drawing.Point(154, 264);
            this.btnPnlClose.Name = "btnPnlClose";
            this.btnPnlClose.Size = new System.Drawing.Size(141, 45);
            this.btnPnlClose.TabIndex = 4;
            this.btnPnlClose.Text = "Cancel";
            this.btnPnlClose.UseVisualStyleBackColor = false;
            this.btnPnlClose.Click += new System.EventHandler(this.btnPnlClose_Click);
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
            // main_panelcontrol
            // 
            this.main_panelcontrol.Angle = 0F;
            this.main_panelcontrol.BackColor = System.Drawing.Color.Transparent;
            this.main_panelcontrol.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.main_panelcontrol.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(203)))), ((int)(((byte)(232)))));
            this.main_panelcontrol.Location = new System.Drawing.Point(12, 215);
            this.main_panelcontrol.Name = "main_panelcontrol";
            this.main_panelcontrol.Rounding = 0;
            this.main_panelcontrol.Size = new System.Drawing.Size(1517, 621);
            this.main_panelcontrol.TabIndex = 0;
            // 
            // Vaccination_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 857);
            this.Controls.Add(this.pnlBack);
            this.Name = "Vaccination_Form";
            this.Text = "VaccinationForm";
            this.Load += new System.EventHandler(this.Vaccination_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBack)).EndInit();
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDatePIcker)).EndInit();
            this.pnlDatePIcker.ResumeLayout(false);
            this.pnlDatePIcker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlVaccineBack.ResumeLayout(false);
            this.pnlVaccineBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VaccinationPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFamily;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblashaname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PanelControl main_panelcontrol;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlBack;
        private System.Windows.Forms.Panel panel2;
        private PanelControl panelControl3;
        private System.Windows.Forms.PictureBox VaccinationPicture;
        private System.Windows.Forms.Button BCG_D1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlDatePIcker;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Vaccination_Place;
        private System.Windows.Forms.DateTimePicker Vaccination_Date;
        private System.Windows.Forms.Button btnAddVaccination;
        private System.Windows.Forms.Panel pnlVaccineBack;
        private System.Windows.Forms.Button HepB_D1;
        private System.Windows.Forms.Button DTaP_D1;
        private System.Windows.Forms.Button HepB_D2;
        private System.Windows.Forms.Button DTaP_D2;
        private System.Windows.Forms.Button HepB_D3;
        private System.Windows.Forms.Button DTaP_D3;
        private System.Windows.Forms.Button DTaP_B1;
        private System.Windows.Forms.Button IPV_B1;
        private System.Windows.Forms.Button Hib_B1;
        private System.Windows.Forms.Button IPV_B2;
        private System.Windows.Forms.Button Tdap_B2;
        private System.Windows.Forms.Button VAR_D2;
        private System.Windows.Forms.Button MMR_D2;
        private System.Windows.Forms.Button PCV_D2;
        private System.Windows.Forms.Button Hib_D2;
        private System.Windows.Forms.Button IPV_D2;
        private System.Windows.Forms.Button Hib_D1;
        private System.Windows.Forms.Button IPV_D1;
        private System.Windows.Forms.Button PCV_D1;
        private System.Windows.Forms.Button PCV_B1;
        private System.Windows.Forms.Button Hib_D3;
        private System.Windows.Forms.Button IPV_D3;
        private System.Windows.Forms.Button VAR_D1;
        private System.Windows.Forms.Button MMR_D1;
        private System.Windows.Forms.Button HPV_D2;
        private System.Windows.Forms.Button HPV_D1;
        private System.Windows.Forms.Button btnPnlClose;
        private System.Windows.Forms.Button btnPersonalProfile;
    }
}